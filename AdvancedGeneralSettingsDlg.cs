﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iRacingSDK.Support;
using WK.Libraries.HotkeyListenerNS;
using iRacingReplayDirector.Support;

namespace iRacingReplayDirector
{
    public partial class AdvancedGeneralSettingsDlg : Form
    {
        private Action onSave;
        private Settings settings;

        //dataBindings for variables to change
        private Binding dataCameraStickyPeriod;
        private Binding dataBattleStickyPeriod;
        private Binding dataBattleGap;
        private Binding dataHighlightVideoTargetDuration;
        private Binding dataFollowLeaderBeforeRaceEndPeriod;
        private Binding dataFollowLeaderAtRaceStartPeriod;

        BindingManagerBase dataBinding;

        internal static HotkeySelector hotKeySelectorStopStart = new HotkeySelector();
        internal static HotkeySelector hotKeySelectorPauseResume = new HotkeySelector();

        public AdvancedGeneralSettingsDlg(Settings settings)
        {
            this.settings = settings;
            InitializeComponent();

            //dataBinding.AddNew();
            
            //DataBindings.Add(this.tbCameraStickyPeriod.DataBindings.Add("Text", this.settings, "CameraStickyPeriod", true, DataSourceUpdateMode.OnPropertyChanged));
            //DataBindings.Add(this.tbCameraStickyPeriod.DataBindings.Add("Text", this.settings, "CameraStickyPeriod", true, DataSourceUpdateMode.OnPropertyChanged));

            dataCameraStickyPeriod = this.tbCameraStickyPeriod.DataBindings.Add("Text", this.settings, "CameraStickyPeriod", true, DataSourceUpdateMode.OnPropertyChanged);
            dataBattleStickyPeriod = this.tbBattleStickyPeriod.DataBindings.Add("Text", this.settings, "BattleStickyPeriod", true, DataSourceUpdateMode.OnPropertyChanged);
            dataBattleGap = this.tbBattleGap.DataBindings.Add("Text", this.settings, "BattleGap", true, DataSourceUpdateMode.OnPropertyChanged);
            dataHighlightVideoTargetDuration = this.tbHighlightVideoTargetDuration.DataBindings.Add("Text", this.settings, "HighlightVideoTargetDuration", true, DataSourceUpdateMode.OnPropertyChanged);
            dataFollowLeaderBeforeRaceEndPeriod = this.tbFollowLeaderBeforeRaceEndPeriod.DataBindings.Add("Text", this.settings, "FollowLeaderBeforeRaceEndPeriod", true, DataSourceUpdateMode.OnPropertyChanged);
            dataFollowLeaderAtRaceStartPeriod = this.tbFollowLeaderAtRaceStartPeriod.DataBindings.Add("Text", this.settings, "FollowLeaderAtRaceStartPeriod", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void textBoxSettingDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCameraStickyPeriod_MouseHover(object sender, EventArgs e)
        {
            textBoxSettingDescription.Text = "The time period that must elapse before a new random camera is selected";
        }

        private void AdvanceGeneralSettingsDlg_Load(object sender, EventArgs e)
        {
            hotKeySelectorStopStart.Enable(tbHotKeyStopStart, Settings.Default.hotKeyStopStart);
            hotKeySelectorPauseResume.Enable(tbHotKeyPauseResume, new Hotkey(Settings.Default.strHotKeyPauseResume));

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox_PerferedDriversOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(CheckBox))
            {
                //enable/disable groupBox Drivers depending on status of checkbox
                Boolean bChecked = ((CheckBox)sender).Checked;
                groupBox_Drivers.Enabled = bChecked;
                foreach (Control ctrl in groupBox_Drivers.Controls)
                    ctrl.Enabled = bChecked;
            }
        }

        private void tabPageTiming_Click(object sender, EventArgs e)
        {

        }

        private void tbBattleGap_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbCameraStickyPeriod_MouseLeave(object sender, EventArgs e)
        {
            ClearToolTipTextbox();
        }

        private void ClearToolTipTextbox()
        {
            textBoxSettingDescription.Text = "";
        }

        private void tbBattleStickyPeriod_MouseHover(object sender, EventArgs e)
        {
            textBoxSettingDescription.Text = "The time period that must elapsed before a new battle is randomly selected.";
        }

        private void tbBattleStickyPeriod_MouseLeave(object sender, EventArgs e)
        {
            ClearToolTipTextbox();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            //Undo of changes of databinding doesn't work at the moment. Even when DataSourceUpdateMode.Never is used. 
            /*dataCameraStickyPeriod.WriteValue();
            dataBattleGap.WriteValue();
            dataBattleStickyPeriod.WriteValue();
            dataBattleGap.WriteValue();
            dataHighlightVideoTargetDuration.WriteValue();
            dataFollowLeaderBeforeRaceEndPeriod.WriteValue();
            dataFollowLeaderAtRaceStartPeriod.WriteValue();*/

            //set Dialog Status to close form
            this.DialogResult = DialogResult.OK;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btTestStopStartHotKey_Click(object sender, EventArgs e)
        {

            Hotkey newHotKey = HotkeyListener.Convert(tbHotKeyStopStart.Text);
            Settings.Default.hotKeyStopStart = newHotKey;

            /*hotkeyListener.Update
            (
                // Reference the current clipping hotkey for directly updating 
                // the hotkey without a need for restarting your application.
                ref MainForm.clippingHotkey,

                // Convert the selected hotkey's text representation 
                // to a Hotkey object and update it.
                HotkeyListener.Convert(txtClippingHotkey.Text)
            );*/
            KeyboardEmulator.SendKeyStrokes(Settings.Default.hotKeyStopStart);
        }

        private void btTestPauseResumeHotKey_Click(object sender, EventArgs e)
        {
            Hotkey newHotKey = HotkeyListener.Convert(tbHotKeyPauseResume.Text);
            Settings.Default.strHotKeyPauseResume = tbHotKeyPauseResume.Text;

            KeyboardEmulator.SendKeyStrokes(newHotKey);
        }
    }
}
