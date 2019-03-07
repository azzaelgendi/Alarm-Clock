/*
 * Simple Alarm
 * Azza Elgendy
 * Revision History
 * created Feb 2nd,2018
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inClass2AlarmClock
{
    public partial class alarmClockForm : Form
    {
        public alarmClockForm()
        {
            InitializeComponent();
        }


        private void alarmClock_load()
        {
            dateTimeLabel.Text = DateTime.Now.ToLongTimeString();

        }

        private void radioButtonAm_CheckedChanged(object sender, EventArgs e)
        {

        }
        string ToDateTime;
        string setAlarm;



        private void timerSet_Tick(object sender, EventArgs e)
        {
            dateTimeLabel.Text = DateTime.Now.ToLongTimeString();
            ToDateTime = DateTime.Now.ToShortTimeString();
            if (alarmActiveCheckBox.Checked)
            {


                if (radioButtonAm.Checked)
                {
                    setAlarm = (setTimercomboBox.Text + ":"
                        + mintuesComboBox.Text + " AM").ToString();
                }
                else if (radioButtonPm.Checked)
                {
                    setAlarm = (setTimercomboBox.Text + ":"
                        + mintuesComboBox.Text + " PM").ToString();
                }
                if (setAlarm == ToDateTime)
                {

                    alarmFiredTextBox.Visible = true;
                    alarmFiredTextBox.Text = ("Alarm!!!!!!");
                    alarmFiredTextBox.ForeColor = Color.Red;
                    errorTextBox.Text = ("Press stop To Stop The Alarm");
                    errorTextBox.ForeColor = Color.Blue;
                }
            }
        }

        private void alarmActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {



            if (alarmActiveCheckBox.Checked == false)
            {
                errorTextBox.Text = "Alarm Off";
            }

            else if (setTimercomboBox.Text == ""
                && mintuesComboBox.Text == ""
                && alarmActiveCheckBox.Checked == true)
            {
                errorTextBox.Text = " Error";

            }
            else if (alarmActiveCheckBox.Checked == true
                && radioButtonAm.Checked == false
                || radioButtonPm.Checked == false)

            {
                errorTextBox.Text = " Error! Check AM or PM button";

            }
            if (alarmActiveCheckBox.Checked == true)


            {
                if ((radioButtonAm.Checked == true
                    || radioButtonPm.Checked == true)
                    && setTimercomboBox.Text != ""
                    && mintuesComboBox.Text != "")
                {
                    errorTextBox.Text = "Alarm On ready to go";
                    errorTextBox.BackColor = Color.PaleGoldenrod;
                }
            }
        }

        private void stopAlarmButton_Click(object sender, EventArgs e)
        {
            alarmActiveCheckBox.Checked = false;
            mintuesComboBox.Text = "";
            radioButtonAm.Checked = false;
            radioButtonPm.Checked = false;
            errorTextBox.Text = "Set The Alarm";
            setTimercomboBox.Text = "";
            errorTextBox.ForeColor = Color.Aquamarine;
            errorTextBox.BackColor = Color.Black;
            alarmFiredTextBox.Visible = false;

        }

        private void dateTimeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
