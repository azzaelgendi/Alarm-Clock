namespace inClass2AlarmClock
{
    partial class alarmClockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stopAlarmButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.alarmActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.amPmgroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonPm = new System.Windows.Forms.RadioButton();
            this.radioButtonAm = new System.Windows.Forms.RadioButton();
            this.timerShow = new System.Windows.Forms.Timer(this.components);
            this.timerSet = new System.Windows.Forms.Timer(this.components);
            this.alarmFiredTextBox = new System.Windows.Forms.TextBox();
            this.setTimercomboBox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mintuesComboBox = new System.Windows.Forms.ComboBox();
            this.amPmgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // stopAlarmButton
            // 
            this.stopAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopAlarmButton.Location = new System.Drawing.Point(519, 39);
            this.stopAlarmButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopAlarmButton.Name = "stopAlarmButton";
            this.stopAlarmButton.Size = new System.Drawing.Size(203, 110);
            this.stopAlarmButton.TabIndex = 0;
            this.stopAlarmButton.Text = "Stop Alarm";
            this.stopAlarmButton.UseVisualStyleBackColor = true;
            this.stopAlarmButton.Click += new System.EventHandler(this.stopAlarmButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(619, 313);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(123, 59);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "about";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // alarmActiveCheckBox
            // 
            this.alarmActiveCheckBox.AutoSize = true;
            this.alarmActiveCheckBox.Location = new System.Drawing.Point(33, 294);
            this.alarmActiveCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alarmActiveCheckBox.Name = "alarmActiveCheckBox";
            this.alarmActiveCheckBox.Size = new System.Drawing.Size(106, 21);
            this.alarmActiveCheckBox.TabIndex = 2;
            this.alarmActiveCheckBox.Text = "alarm active";
            this.alarmActiveCheckBox.UseVisualStyleBackColor = true;
            this.alarmActiveCheckBox.CheckedChanged += new System.EventHandler(this.alarmActiveCheckBox_CheckedChanged);
            // 
            // errorTextBox
            // 
            this.errorTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTextBox.Location = new System.Drawing.Point(31, 335);
            this.errorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.Size = new System.Drawing.Size(561, 36);
            this.errorTextBox.TabIndex = 3;
            this.errorTextBox.Text = "Set The Alarm";
            this.errorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dateTimeLabel.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.dateTimeLabel.Location = new System.Drawing.Point(27, 39);
            this.dateTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(484, 105);
            this.dateTimeLabel.TabIndex = 5;
            this.dateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimeLabel.Click += new System.EventHandler(this.dateTimeLabel_Click);
            // 
            // amPmgroupBox
            // 
            this.amPmgroupBox.Controls.Add(this.radioButtonPm);
            this.amPmgroupBox.Controls.Add(this.radioButtonAm);
            this.amPmgroupBox.Location = new System.Drawing.Point(388, 197);
            this.amPmgroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amPmgroupBox.Name = "amPmgroupBox";
            this.amPmgroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amPmgroupBox.Size = new System.Drawing.Size(224, 84);
            this.amPmgroupBox.TabIndex = 6;
            this.amPmgroupBox.TabStop = false;
            // 
            // radioButtonPm
            // 
            this.radioButtonPm.AutoSize = true;
            this.radioButtonPm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPm.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonPm.Location = new System.Drawing.Point(108, 42);
            this.radioButtonPm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonPm.Name = "radioButtonPm";
            this.radioButtonPm.Size = new System.Drawing.Size(61, 28);
            this.radioButtonPm.TabIndex = 1;
            this.radioButtonPm.TabStop = true;
            this.radioButtonPm.Text = "PM";
            this.radioButtonPm.UseVisualStyleBackColor = true;
            // 
            // radioButtonAm
            // 
            this.radioButtonAm.AutoSize = true;
            this.radioButtonAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAm.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonAm.Location = new System.Drawing.Point(33, 42);
            this.radioButtonAm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonAm.Name = "radioButtonAm";
            this.radioButtonAm.Size = new System.Drawing.Size(62, 28);
            this.radioButtonAm.TabIndex = 0;
            this.radioButtonAm.TabStop = true;
            this.radioButtonAm.Text = "AM";
            this.radioButtonAm.UseVisualStyleBackColor = true;
            this.radioButtonAm.CheckedChanged += new System.EventHandler(this.radioButtonAm_CheckedChanged);
            // 
            // timerShow
            // 
            this.timerShow.Enabled = true;
            // 
            // timerSet
            // 
            this.timerSet.Enabled = true;
            this.timerSet.Interval = 1000;
            this.timerSet.Tick += new System.EventHandler(this.timerSet_Tick);
            // 
            // alarmFiredTextBox
            // 
            this.alarmFiredTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmFiredTextBox.Location = new System.Drawing.Point(31, 202);
            this.alarmFiredTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alarmFiredTextBox.Name = "alarmFiredTextBox";
            this.alarmFiredTextBox.Size = new System.Drawing.Size(265, 34);
            this.alarmFiredTextBox.TabIndex = 4;
            this.alarmFiredTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alarmFiredTextBox.Visible = false;
            // 
            // setTimercomboBox
            // 
            this.setTimercomboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTimercomboBox.FormattingEnabled = true;
            this.setTimercomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.setTimercomboBox.Location = new System.Drawing.Point(35, 247);
            this.setTimercomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setTimercomboBox.Name = "setTimercomboBox";
            this.setTimercomboBox.Size = new System.Drawing.Size(160, 30);
            this.setTimercomboBox.TabIndex = 7;
            // 
            // mintuesComboBox
            // 
            this.mintuesComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mintuesComboBox.FormattingEnabled = true;
            this.mintuesComboBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "54",
            "55",
            "56",
            "59"});
            this.mintuesComboBox.Location = new System.Drawing.Point(203, 247);
            this.mintuesComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mintuesComboBox.Name = "mintuesComboBox";
            this.mintuesComboBox.Size = new System.Drawing.Size(160, 30);
            this.mintuesComboBox.TabIndex = 8;
            // 
            // alarmClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(757, 391);
            this.Controls.Add(this.mintuesComboBox);
            this.Controls.Add(this.setTimercomboBox);
            this.Controls.Add(this.amPmgroupBox);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.alarmFiredTextBox);
            this.Controls.Add(this.errorTextBox);
            this.Controls.Add(this.alarmActiveCheckBox);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.stopAlarmButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "alarmClockForm";
            this.Text = "DT Alarm Clock";
            this.amPmgroupBox.ResumeLayout(false);
            this.amPmgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stopAlarmButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.CheckBox alarmActiveCheckBox;
        private System.Windows.Forms.TextBox errorTextBox;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.GroupBox amPmgroupBox;
        private System.Windows.Forms.RadioButton radioButtonAm;
        private System.Windows.Forms.RadioButton radioButtonPm;
        private System.Windows.Forms.Timer timerShow;
        private System.Windows.Forms.Timer timerSet;
        private System.Windows.Forms.TextBox alarmFiredTextBox;
        private System.Windows.Forms.ComboBox setTimercomboBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox mintuesComboBox;
    }
}

