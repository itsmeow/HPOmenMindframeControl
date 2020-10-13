using Hp.Bridge.Client.SDKs.McuHeadSetSDK;
using Hp.Bridge.Client.SDKs.McuHeadSetSDK.CallBacks;
using Hp.Bridge.Client.SDKs.McuHeadSetSDK.Enums;
using Hp.Bridge.Client.SDKs.McuHeadSetSDK.Structures;
using HP.Omen.AccessoryHeadsetCoolingModule;
using HP.Omen.AccessoryHeadsetCoolingModule.Models;
using HP.Omen.AccessoryHeadsetLightingModule.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindframeControl
{
    public partial class MainControl : Form
    {
        private int hidIndex = 0;
        private int hidIndex_regular = 0;
        private int hidIndex_prime = 0;
        private OMENHeadsets currentHeadset;
        private const int HEIGHT_NO_SELECT = 261;
        private const int HEIGHT_SELECT = 280;
        private const int WIDTH_NO_SELECT = 905;
        private const int WIDTH_SELECT = 504;
        private const int MINDFRAME_PID = 10305;
        private const int MINDFRAME_PRIME_PID = 12865;
        private const int MINDFRAME_VID = 1008;
        private string REGISTRY_PATH = "SOFTWARE\\its_meow\\OMEN_CONTROL";
        private Font REGULAR_FONT;
        private Font BOLD_FONT;
        private List<Color> defaultAnimationColorsC = new List<Color>()
        {
            Color.Red,
            Color.FromArgb(250, 113, 15),
            Color.FromArgb(250, 211, 15),
            Color.FromArgb(15, 250, 54),
            Color.FromArgb(15, 54, 250),
            Color.FromArgb(191, 15, 250)
        };
        private List<HeadSetRGBColor> defaultAnimationColors;

        public MainControl()
        {
            InitializeComponent();
            REGULAR_FONT = new Font(lblOff.Font, FontStyle.Regular);
            BOLD_FONT = new Font(lblOff.Font, FontStyle.Bold);
            defaultAnimationColors = toHeadSetColors(defaultAnimationColorsC);
        }

        private async void CoolingBar_Scroll(object sender, EventArgs e)
        {
            HeadSetCoolingModes mode = (HeadSetCoolingModes)CoolingBar.Value;
            await setCooling(mode);
        }

        private void setHeadset(OMENHeadsets headset)
        {
            currentHeadset = headset;
            hidIndex = headset == OMENHeadsets.Mindframe ? hidIndex_regular : hidIndex_prime;
            REGISTRY_PATH = "SOFTWARE\\its_meow\\OMEN_CONTROL" + (headset == OMENHeadsets.MindframePrime ? "\\PRIME" : "");
        }

        private void setMultiMode(bool on)
        {
            this.Height = on ? HEIGHT_SELECT : HEIGHT_NO_SELECT;
            this.Width = on ? WIDTH_SELECT : WIDTH_NO_SELECT;
            this.lblSelectHeadset.Visible = on;
            this.headsetBox.Visible = on;
            this.audioGroupBox.Visible = !on;
        }

        private async void MainControl_Load(object sender, EventArgs e)
        {
            hidIndex_regular = await AccessoryHeadSetHelper.Initialize(MINDFRAME_PID, MINDFRAME_VID, string.Empty);
            hidIndex_prime = await AccessoryHeadSetHelper.Initialize(MINDFRAME_PRIME_PID, MINDFRAME_VID, string.Empty);
            if (hidIndex_regular != -1 && hidIndex_prime != -1)
            {
                await AccessoryHeadSetHelper.UnInitialize(hidIndex_prime);
                setMultiMode(true);
                this.headsetBox.SelectedIndex = (int) OMENHeadsets.Mindframe;
            } else if(hidIndex_regular == -1 && hidIndex_prime == -1)
            {
                MessageBox.Show("Could not find any Mindframe devices.");
                Environment.Exit(1);
            } else
            {
                setMultiMode(false);
                setHeadset(hidIndex_regular != -1 ? OMENHeadsets.Mindframe : OMENHeadsets.MindframePrime);
                initHeadset();
            }
        }

        private async void initHeadset()
        {
            HeadSetCoolingModes coolingMode = GetCoolingLevelFromRegistry();
            Color staticColor = GetColorRegistry();
            staticColorPanel.BackColor = staticColor;
            CoolingBar.Value = (int)coolingMode;
            await setCooling(coolingMode);
            HeadsetLightingEnum lightMode = GetLightModeRegistry();
            colorModeBox.SelectedIndex = (int)lightMode;

            ResultCodes result = AccessoryHeadsetDriverHelper.InitializeDriverWithGuid(currentHeadset, new Guid("{947D0033-02A6-48FB-AD23-47407B97D158}"));
            checkErrors(result);
            updateVolumes();
            surroundCheckBox.Checked = getSpeakerFeature(SpeakerFeatures.Surround);
            surroundMaxCheckBox.Checked = getSpeakerFeature(SpeakerFeatures.SurroundMax);
            dynamicBassCheckBox.Checked = getSpeakerFeature(SpeakerFeatures.DynamicBass);
            encCheckBox.Checked = getMicFeature(MicrophoneFeatures.EnvironmentalNoiseCancellation);
            encCheckBox.Visible = currentHeadset == OMENHeadsets.MindframePrime;
            AccessoryHeadsetDriverHelper.RegisterAudioVolumeCallBack(currentHeadset, new OMENAudioVolumeCallback(this.AudioLevelCallBack));
        }

        private async void MainControl_Close(object sender, EventArgs e)
        {
            await AccessoryHeadSetHelper.UnInitialize(hidIndex);
            ResultCodes result = AccessoryHeadsetDriverHelper.UnInitializeDriver(currentHeadset);
            checkErrors(result);
        }

        private void AudioLevelCallBack()
        {
            if(InvokeRequired) {
                this.Invoke(new MethodInvoker(delegate {
                    updateVolumes();
                }));
                return;
            }
        }

        private void SurroundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setSpeakerFeature(SpeakerFeatures.Surround, surroundCheckBox.Checked);
        }

        private void SurroundMaxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setSpeakerFeature(SpeakerFeatures.SurroundMax, surroundMaxCheckBox.Checked);
        }

        private void DynamicBassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setSpeakerFeature(SpeakerFeatures.DynamicBass, dynamicBassCheckBox.Checked);
        }

        private void EncCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setMicFeature(MicrophoneFeatures.EnvironmentalNoiseCancellation, encCheckBox.Checked);
        }

        private async void btnStaticColor_Click(object sender, EventArgs e)
        {
            HeadsetLightingEnum mode = (HeadsetLightingEnum)colorModeBox.SelectedIndex;
            if (mode == HeadsetLightingEnum.Static)
            {
                ColorPicker picker = new ColorPicker(this, staticColorPanel.BackColor);
                DialogResult result = picker.ShowDialog();
                // reset to original color if cancel hit
                if (result == DialogResult.Cancel)
                {
                    if (picker.color != null)
                    {
                        await setStaticColor(picker.color);
                    }
                }
            }
        }

        private async void btnColorList_Click(object sender, EventArgs e)
        {
            HeadsetLightingEnum mode = (HeadsetLightingEnum)colorModeBox.SelectedIndex;
            if (mode == HeadsetLightingEnum.ColorShift) {
                ColorList list = new ColorList(GetColorListRegistry("BlinkingColors"));
                DialogResult result = list.ShowDialog();
                if (result == DialogResult.OK)
                {
                    await setBlinkingAnimation(list.colors);
                }
            }
        }

        private async void colorLengthBox_ValueChanged(object sender, EventArgs e)
        {
            HeadsetLightingEnum mode = (HeadsetLightingEnum)colorModeBox.SelectedIndex;
            if (mode == HeadsetLightingEnum.ColorShift)
            {
                await setBlinkingAnimation(GetColorListRegistry("BlinkingColors"));
            }
        }

        private async void colorModeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HeadsetLightingEnum mode = (HeadsetLightingEnum)colorModeBox.SelectedIndex;
            SetLightModeRegistry(mode);
            switch (mode)
            {
                case HeadsetLightingEnum.ColorShift:
                    btnStaticColor.Enabled = false;
                    btnColorList.Enabled = true;
                    colorLengthBox.Enabled = true;
                    await setBlinkingAnimation(GetColorListRegistry("BlinkingColors"));
                    break;
                case HeadsetLightingEnum.Audio:
                    btnStaticColor.Enabled = false;
                    btnColorList.Enabled = false;
                    colorLengthBox.Enabled = false;
                    await setAudioAnimation();
                    break;
                case HeadsetLightingEnum.Static:
                    btnStaticColor.Enabled = true;
                    btnColorList.Enabled = false;
                    colorLengthBox.Enabled = false;
                    await setStaticColor(GetColorRegistry());
                    break;
                case HeadsetLightingEnum.OFF:
                    btnStaticColor.Enabled = false;
                    btnColorList.Enabled = false;
                    colorLengthBox.Enabled = false;
                    HeadSetErrorCode error = await AccessoryHeadSetHelper.SetHeadsetStaticColorAsync(hidIndex, toHeadSetColor(Color.Black));
                    if (checkErrors(error))
                    {
                        staticColorPanel.BackColor = Color.Black;
                    }
                    break;
            }
        }

        private void SpeakerVolumeBar_Scroll(object sender, EventArgs e)
        {
            if(speakerVolumeBar.Value == 0)
            {
                muteHeadphoneBox.Checked = true;
            } else
            {
                if(getRegistryMuted(AudioLevels.Headphone) || muteHeadphoneBox.Checked)
                {
                    muteHeadphoneBox.Checked = false;
                    SetBoolRegistry("SpeakerMuted", false);
                }
                SetAudioLevelValue(AudioLevels.Headphone, speakerVolumeBar.Value);
            }
        }

        private void MuteHeadphoneBox_CheckedChanged(object sender, EventArgs e)
        {
            setMuted(AudioLevels.Headphone, muteHeadphoneBox.Checked);
        }


        private void MicVolumeBar_Scroll(object sender, EventArgs e)
        {
            if (micVolumeBar.Value == 0)
            {
                muteMicrophoneBox.Checked = true;
            }
            else
            {
                if (getRegistryMuted(AudioLevels.Mic) || muteMicrophoneBox.Checked)
                {
                    muteMicrophoneBox.Checked = false;
                    SetBoolRegistry("MicMuted", false);
                }
                SetAudioLevelValue(AudioLevels.Mic, micVolumeBar.Value);
            }
        }

        private void SidetoneVolumeBar_Scroll(object sender, EventArgs e)
        {
            if (sidetoneVolumeBar.Value == 0)
            {
                muteSidetoneBox.Checked = true;
            }
            else
            {
                if (getRegistryMuted(AudioLevels.SideTone) || muteSidetoneBox.Checked)
                {
                    muteSidetoneBox.Checked = false;
                    SetBoolRegistry("SidetoneMuted", false);
                }
                SetAudioLevelValue(AudioLevels.SideTone, sidetoneVolumeBar.Value);
            }
        }

        private void MuteMicrophoneBox_CheckedChanged(object sender, EventArgs e)
        {
            setMuted(AudioLevels.Mic, muteMicrophoneBox.Checked);
        }

        private void MuteSidetoneBox_CheckedChanged(object sender, EventArgs e)
        {
            setMuted(AudioLevels.SideTone, muteSidetoneBox.Checked);
        }

        /*
         * Helpers
         */

        public async Task<HeadSetErrorCode> setStaticColor(Color color)
        {
            if (color.Name == "ff000000" || color.Name == "Black")
            {
                colorModeBox.SelectedIndex = (int)HeadsetLightingEnum.OFF;
                return HeadSetErrorCode.HID_WriteSuccess;
            }
            if (colorModeBox.SelectedIndex != (int)HeadsetLightingEnum.Static)
            {
                SetColorRegistry(color);
                colorModeBox.SelectedIndex = (int)HeadsetLightingEnum.Static;
                return HeadSetErrorCode.HID_WriteSuccess;
            }
            HeadSetErrorCode error = await AccessoryHeadSetHelper.SetHeadsetStaticColorAsync(hidIndex, toHeadSetColor(color));
            if (checkErrors(error))
            {
                staticColorPanel.BackColor = color;
                if (color.Name != "ff000000" && color.Name != "Black")
                {
                    SetColorRegistry(color);
                }
            }
            return error;
        }

        private async Task<HeadSetErrorCode> setCooling(HeadSetCoolingModes mode)
        {
            HeadSetErrorCode result = await AccessoryHeadSetHelper.SetHeadsetCoolingAsync(hidIndex, mode);
            if (checkErrors(result))
            {
                this.SaveCoolingLevelToRegistry(mode);
                highlightLabel(mode);
            }
            return result;
        }

        private async Task<HeadSetErrorCode> setAudioAnimation()
        {
            if (colorModeBox.SelectedIndex != (int)HeadsetLightingEnum.Audio)
            {
                colorModeBox.SelectedIndex = (int)HeadsetLightingEnum.Audio;
                return HeadSetErrorCode.HID_WriteSuccess;
            }
            HeadSetErrorCode result = await AccessoryHeadSetHelper.SetHeadsetAnimationAsync(hidIndex, HeadsetAnimation.Audio, defaultAnimationColors, 0);
            checkErrors(result);
            return result;
        }

        private async Task<HeadSetErrorCode> setBlinkingAnimation(List<Color> colors)
        {
            if (colorModeBox.SelectedIndex != (int)HeadsetLightingEnum.ColorShift)
            {
                SetColorListRegistry("BlinkingColors", colors);
                colorModeBox.SelectedIndex = (int)HeadsetLightingEnum.ColorShift;
                return HeadSetErrorCode.HID_WriteSuccess;
            }
            HeadSetErrorCode result = await AccessoryHeadSetHelper.SetHeadsetAnimationAsync(hidIndex, HeadsetAnimation.Blinking, toHeadSetColors(colors), (ushort)colorLengthBox.Value);
            if (checkErrors(result))
            {
                this.SetColorListRegistry("BlinkingColors", colors);
            }
            return result;
        }

        private bool getMicFeature(MicrophoneFeatures micFeature)
        {

            bool enable = false;
            if (micFeature == MicrophoneFeatures.EnvironmentalNoiseCancellation)
            {
                enable = GetBoolRegistry(micFeature.ToString(), false);
            }
            else
            {
                ResultCodes result = AccessoryHeadsetDriverHelper.GetMicrophoneFeatureEnable(currentHeadset, micFeature, out enable);
                checkErrors(result);
            }
            return enable;
        }

        private bool getSpeakerFeature(SpeakerFeatures feature)
        {

            bool enable = false;
           
            if(feature == SpeakerFeatures.SurroundMax || feature == SpeakerFeatures.DynamicBass)
            {
                enable = GetBoolRegistry(feature.ToString(), false);
            } else
            {
                ResultCodes result = AccessoryHeadsetDriverHelper.GetSpeakerFeatureEnable(currentHeadset, feature, out enable);
                checkErrors(result);
            }
            return enable;
        }

        public void setMuted(AudioLevels type, bool muted)
        {
            switch (type)
            {
                case AudioLevels.Headphone:
                    setSpeakerMuted(muted);
                    break;
                case AudioLevels.Mic:
                    setMicMuted(muted);
                    break;
                case AudioLevels.SideTone:
                    setSidetoneMuted(muted);
                    break;
            }
        }

        public bool getRegistryMuted(AudioLevels type)
        {
            switch (type)
            {
                case AudioLevels.Headphone:
                    return GetBoolRegistry("SpeakerMuted", false);
                case AudioLevels.Mic:
                    return GetBoolRegistry("MicMuted", false);
                case AudioLevels.SideTone:
                    return GetBoolRegistry("SidetoneMuted", false);
            }
            return false;
        }

        public void SetAudioLevelValue(AudioLevels type, double newValue)
        {
            float value = (float)(newValue / 100.0);
            if (type == AudioLevels.Headphone)
            {
                ResultCodes result = AccessoryHeadsetDriverHelper.SetSpeakerVolumeValue(currentHeadset, new VolumeChannel()
                {
                    ChannelIndex = OMENVolumeChannels.Master,
                    ChannelValue = value
                });
                checkErrors(result);
            }
            else if (type == AudioLevels.Mic)
            {
                ResultCodes result = AccessoryHeadsetDriverHelper.SetMicrophoneVolumeValue(currentHeadset, new VolumeChannel()
                {
                    ChannelIndex = OMENVolumeChannels.Master,
                    ChannelValue = value
                });
                checkErrors(result);
            }
            else
            {
                if (type != AudioLevels.SideTone)
                    return;

                VolumeChannel volumeChannel = new VolumeChannel();
                volumeChannel.ChannelIndex = OMENVolumeChannels.FrontLeft;
                volumeChannel.ChannelValue = value;
                VolumeChannel sideToneChannel1 = volumeChannel;
                ResultCodes result = AccessoryHeadsetDriverHelper.SetSideToneVolumeValue(currentHeadset, sideToneChannel1);
                checkErrors(result);
                volumeChannel = new VolumeChannel();
                volumeChannel.ChannelIndex = OMENVolumeChannels.FrontRight;
                volumeChannel.ChannelValue = value;
                VolumeChannel sideToneChannel2 = volumeChannel;
                ResultCodes result2 = AccessoryHeadsetDriverHelper.SetSideToneVolumeValue(currentHeadset, sideToneChannel2);
                checkErrors(result2);
            }
        }

        public void setSpeakerMuted(bool isMute)
        {
            ResultCodes result = AccessoryHeadsetDriverHelper.SetSpeakerIsMuted(currentHeadset, isMute);
            if (checkErrors(result))
            {
                SetBoolRegistry("SpeakerMuted", isMute);
            }
        }

        public void setSidetoneMuted(bool isMute)
        {
            ResultCodes result = AccessoryHeadsetDriverHelper.SetSideToneIsMuted(currentHeadset, isMute);
            if(checkErrors(result))
            {
                SetBoolRegistry("SidetoneMuted", isMute);
            }
        }

        public void setMicMuted(bool isMute)
        {
            ResultCodes result = AccessoryHeadsetDriverHelper.SetMicrophoneIsMuted(currentHeadset, isMute);
            if(checkErrors(result))
            {
                SetBoolRegistry("MicMuted", isMute);
            }
        }

        public void setSpeakerFeature(SpeakerFeatures feature, bool enabled)
        {
            ResultCodes result = AccessoryHeadsetDriverHelper.SetSpeakerFeatureEnable(currentHeadset, feature, enabled);
            if (checkErrors(result)) {
                SetBoolRegistry(feature.ToString(), enabled);
            }
        }

        public void setMicFeature(MicrophoneFeatures feature, bool enabled)
        {
            ResultCodes result = AccessoryHeadsetDriverHelper.SetMicrophoneFeatureEnable(currentHeadset, feature, enabled);
            if(checkErrors(result)){
                SetBoolRegistry(feature.ToString(), enabled);
            }
        }

        public double GetAudioLevelValue(AudioLevels v)
        {
            double num = 0.0;
            switch (v)
            {
                case AudioLevels.Headphone:
                    int speakerVolumeValue = (int)AccessoryHeadsetDriverHelper.GetSpeakerVolumeValue(currentHeadset, new VolumeChannel()
                    {
                        ChannelIndex = OMENVolumeChannels.Master
                    }, out num);
                    break;
                case AudioLevels.Mic:
                    int microphoneVolumeValue = (int)AccessoryHeadsetDriverHelper.GetMicrophoneVolumeValue(currentHeadset, new VolumeChannel()
                    {
                        ChannelIndex = OMENVolumeChannels.Master
                    }, out num);
                    break;
                case AudioLevels.SideTone:
                    int sideToneVolumeValue = (int)AccessoryHeadsetDriverHelper.GetSideToneVolumeValue(currentHeadset, new VolumeChannel()
                    {
                        ChannelIndex = OMENVolumeChannels.FrontLeft
                    }, out num);
                    break;
            }
            num = Math.Ceiling(num * 100.0);
            return num;
        }

        private void highlightLabel(HeadSetCoolingModes mode)
        {
            lblOff.Font = mode == HeadSetCoolingModes.Off ? BOLD_FONT : REGULAR_FONT;
            lblMin.Font = mode == HeadSetCoolingModes.Light ? BOLD_FONT : REGULAR_FONT;
            lblMed.Font = mode == HeadSetCoolingModes.Medium ? BOLD_FONT : REGULAR_FONT;
            lblMax.Font = mode == HeadSetCoolingModes.High ? BOLD_FONT : REGULAR_FONT;
        }

        public static HeadSetRGBColor toHeadSetColor(Color color)
        {
            return new HeadSetRGBColor() { R = color.R, G = color.G, B = color.B };
        }

        public static List<HeadSetRGBColor> toHeadSetColors(List<Color> colors)
        {
            List<HeadSetRGBColor> colorsOut = new List<HeadSetRGBColor>();
            foreach(Color color in colors)
            {
                colorsOut.Add(toHeadSetColor(color));
            }
            return colorsOut;
        }

        private void updateVolumes()
        {
            int speakerLevel = (int)GetAudioLevelValue(AudioLevels.Headphone);
            speakerVolumeBar.Value = speakerLevel;
            muteHeadphoneBox.Checked = speakerLevel == 0;

            int micLevel = (int)GetAudioLevelValue(AudioLevels.Mic);
            micVolumeBar.Value = micLevel;
            muteMicrophoneBox.Checked = micLevel == 0;

            int sidetoneLevel = (int)GetAudioLevelValue(AudioLevels.SideTone);
            sidetoneVolumeBar.Value = sidetoneLevel;
            muteSidetoneBox.Checked = sidetoneLevel == 0;
        }

        private bool checkErrors(ResultCodes error)
        {
            if(error != ResultCodes.Driver_Success)
            {
                MessageBox.Show(error.ToString());
                this.Close();
                return false;
            }
            return true;
        }

        private bool checkErrors(HeadSetErrorCode error)
        {
            if (error != HeadSetErrorCode.HID_WriteSuccess)
            {
                MessageBox.Show(error.ToString());
                this.Close();
                return false;
            }
            return true;
        }

        /* 
         * Registry
         */

        public void SaveCoolingLevelToRegistry(HeadSetCoolingModes coolingLevel)
        {
            Registry.CurrentUser.CreateSubKey(REGISTRY_PATH).SetValue("CoolingLevel", (object)(int)coolingLevel, RegistryValueKind.DWord);
        }

        public HeadSetCoolingModes GetCoolingLevelFromRegistry()
        {
            return (HeadSetCoolingModes)Registry.CurrentUser.CreateSubKey(REGISTRY_PATH).GetValue("CoolingLevel", (object)HeadSetCoolingModes.Off);
        }

        public void SetColorRegistry(Color color)
        {
            Registry.CurrentUser.CreateSubKey(REGISTRY_PATH).SetValue("StaticColor", color.ToArgb(), RegistryValueKind.DWord);
        }

        public Color GetColorRegistry()
        {
            return Color.FromArgb((int)Registry.CurrentUser.CreateSubKey(REGISTRY_PATH).GetValue("StaticColor", Color.Red.ToArgb()));
        }

        public void SetLightModeRegistry(HeadsetLightingEnum mode)
        {
            Registry.CurrentUser.CreateSubKey(REGISTRY_PATH).SetValue("LightMode", (int)mode, RegistryValueKind.DWord);
        }

        public HeadsetLightingEnum GetLightModeRegistry()
        {
            return (HeadsetLightingEnum)Registry.CurrentUser.CreateSubKey(REGISTRY_PATH).GetValue("LightMode", HeadsetLightingEnum.Static);
        }

        public void SetBoolRegistry(string key, bool val)
        {
            Registry.CurrentUser.CreateSubKey(REGISTRY_PATH).SetValue(key, val ? 1 : 0, RegistryValueKind.DWord);
        }

        public bool GetBoolRegistry(string key, bool def)
        {
            return (int)Registry.CurrentUser.CreateSubKey(REGISTRY_PATH).GetValue(key, def ? 1 : 0) == 1;
        }

        public void SetColorListRegistry(string key, List<Color> list)
        {
            List<String> strings = new List<String>();
            foreach (Color color in list)
            {
                strings.Add(color.ToArgb().ToString());
            }
            Registry.CurrentUser.CreateSubKey(REGISTRY_PATH).SetValue(key, strings.ToArray(), RegistryValueKind.MultiString);
        }

        public List<Color> GetColorListRegistry(string key)
        {
            String[] reg = (String[])Registry.CurrentUser.CreateSubKey(REGISTRY_PATH).GetValue(key);
            if (reg != null)
            {
                List<Color> colors = new List<Color>();
                foreach (String str in reg)
                {
                    colors.Add(Color.FromArgb(int.Parse(str)));
                }
                return colors;
            }
            return defaultAnimationColorsC;
        }

        public enum AudioLevels {
            Headphone,
            Mic,
            SideTone,
        }

        private async void HeadsetBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // de-init
            await AccessoryHeadSetHelper.UnInitialize(hidIndex);
            ResultCodes result = AccessoryHeadsetDriverHelper.UnInitializeDriver(currentHeadset);
            // update
            OMENHeadsets target = (OMENHeadsets)this.headsetBox.SelectedIndex;
            if (target == OMENHeadsets.Mindframe)
            {
                hidIndex_regular = await AccessoryHeadSetHelper.Initialize(MINDFRAME_PID, MINDFRAME_VID, string.Empty);
            }
            else
            {
                hidIndex_prime = await AccessoryHeadSetHelper.Initialize(MINDFRAME_PRIME_PID, MINDFRAME_VID, string.Empty);
            }
            setHeadset(target);
            // init!
            initHeadset();
        }

    }
}
