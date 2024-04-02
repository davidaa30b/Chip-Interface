using System.Windows.Forms;

namespace ArduinoInterfaceFormsApp
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.unitLabel7 = new System.Windows.Forms.Label();
            this.rangeLabel7 = new System.Windows.Forms.Label();
            this.textBoxPowerSupplyResetCounts = new System.Windows.Forms.TextBox();
            this.powerSupplyResetCountslabel = new System.Windows.Forms.Label();
            this.rangeLabel6 = new System.Windows.Forms.Label();
            this.textBoxBsrMeasurementTime = new System.Windows.Forms.TextBox();
            this.bsrMeasurementTimeLabel = new System.Windows.Forms.Label();
            this.rangeLabel5 = new System.Windows.Forms.Label();
            this.batteryCapacityLabel = new System.Windows.Forms.Label();
            this.textBoxRatioSlowFastTimer = new System.Windows.Forms.TextBox();
            this.ratioForSlowAndFastTimerLabel = new System.Windows.Forms.Label();
            this.rangeLabel4 = new System.Windows.Forms.Label();
            this.rangeLabel3 = new System.Windows.Forms.Label();
            this.rangeLabel1 = new System.Windows.Forms.Label();
            this.rangeForPropertiesLabel = new System.Windows.Forms.Label();
            this.Topiclabel = new System.Windows.Forms.Label();
            this.textBoxPeriodicInterrupTime = new System.Windows.Forms.TextBox();
            this.unitLabel5 = new System.Windows.Forms.Label();
            this.periodicInteruruptTimelabel = new System.Windows.Forms.Label();
            this.unitLabel4 = new System.Windows.Forms.Label();
            this.textBoxBatteryCapacity = new System.Windows.Forms.TextBox();
            this.unitLabel2 = new System.Windows.Forms.Label();
            this.unitLabel1 = new System.Windows.Forms.Label();
            this.textBoxRsnsb = new System.Windows.Forms.TextBox();
            this.rsnsbLabel = new System.Windows.Forms.Label();
            this.comboBoxBatteryVoltage = new System.Windows.Forms.ComboBox();
            this.batteryVoltageLabel = new System.Windows.Forms.Label();
            this.ApplyChangesButton = new System.Windows.Forms.Button();
            this.unitLabel8 = new System.Windows.Forms.Label();
            this.rangeLabel8 = new System.Windows.Forms.Label();
            this.textBoxBasicBSRHiAlert = new System.Windows.Forms.TextBox();
            this.basicBSRHiAlertlabel = new System.Windows.Forms.Label();
            this.unitLabel9 = new System.Windows.Forms.Label();
            this.rangeLabel9 = new System.Windows.Forms.Label();
            this.textBoxBasicBSRLoAlertLimit = new System.Windows.Forms.TextBox();
            this.BasicBsrLoAlertLimitlabel = new System.Windows.Forms.Label();
            this.unitLabel10 = new System.Windows.Forms.Label();
            this.comboBoxDieTempHiAlertLimitTarget = new System.Windows.Forms.ComboBox();
            this.dieTempHiAlertLimitTargetlabel = new System.Windows.Forms.Label();
            this.unitLabel11 = new System.Windows.Forms.Label();
            this.rangeLabel10 = new System.Windows.Forms.Label();
            this.dieTempHisteresisValueLabel = new System.Windows.Forms.Label();
            this.textBoxDieTempHisteresisValue = new System.Windows.Forms.TextBox();
            this.textBoxTRSTemperature = new System.Windows.Forms.TextBox();
            this.unitLabel12 = new System.Windows.Forms.Label();
            this.rangeLabel11 = new System.Windows.Forms.Label();
            this.trsTemperatureLabel = new System.Windows.Forms.Label();
            this.textBoxTRETemperature = new System.Windows.Forms.TextBox();
            this.unitLabel13 = new System.Windows.Forms.Label();
            this.rangeLabel12 = new System.Windows.Forms.Label();
            this.tretTemperatureLabel = new System.Windows.Forms.Label();
            this.textBoxBasicBatteryVoltageLoAlertLimit = new System.Windows.Forms.TextBox();
            this.unitLabel14 = new System.Windows.Forms.Label();
            this.basicBatteryVoltageLoAlertLimitLabel = new System.Windows.Forms.Label();
            this.curRangeRSNSITextLabel = new System.Windows.Forms.Label();
            this.curRangeRSNSIValueLabel = new System.Windows.Forms.Label();
            this.curRangeBasicVoltageLoAlertLimitValueLabel = new System.Windows.Forms.Label();
            this.curRangeBasicVoltageLoAlertLimitTextLabel = new System.Windows.Forms.Label();
            this.unitLabel3 = new System.Windows.Forms.Label();
            this.textBoxRsnsi = new System.Windows.Forms.TextBox();
            this.rsnsiLabel = new System.Windows.Forms.Label();
            this.unitLabel6 = new System.Windows.Forms.Label();
            this.curRangeBasicVoltageHiAlertLimitTextLabel = new System.Windows.Forms.Label();
            this.textBoxBasicBatteryVoltageHiAlertLimit = new System.Windows.Forms.TextBox();
            this.unitLabel15 = new System.Windows.Forms.Label();
            this.basicBatteryVoltageHiAlertLimitLabel = new System.Windows.Forms.Label();
            this.curRangeBasicVoltageHiAlertLimitValueLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.unitLabel16 = new System.Windows.Forms.Label();
            this.rangeLabel13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.unitLabel17 = new System.Windows.Forms.Label();
            this.rangeLabel14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.unitLabel18 = new System.Windows.Forms.Label();
            this.rangeLabel15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.unitLabel19 = new System.Windows.Forms.Label();
            this.rangeLabel16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.unitLabel20 = new System.Windows.Forms.Label();
            this.rangeLabel17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.unitLabel21 = new System.Windows.Forms.Label();
            this.rangeLabel18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.unitLabel22 = new System.Windows.Forms.Label();
            this.rangeLabel19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.unitLabel23 = new System.Windows.Forms.Label();
            this.rangeLabel20 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unitLabel7
            // 
            this.unitLabel7.AutoSize = true;
            this.unitLabel7.Location = new System.Drawing.Point(435, 418);
            this.unitLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel7.Name = "unitLabel7";
            this.unitLabel7.Size = new System.Drawing.Size(94, 20);
            this.unitLabel7.TabIndex = 172;
            this.unitLabel7.Text = "Milliseconds";
            // 
            // rangeLabel7
            // 
            this.rangeLabel7.AutoSize = true;
            this.rangeLabel7.Location = new System.Drawing.Point(546, 416);
            this.rangeLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel7.Name = "rangeLabel7";
            this.rangeLabel7.Size = new System.Drawing.Size(139, 20);
            this.rangeLabel7.TabIndex = 171;
            this.rangeLabel7.Text = "Range (500-5000)";
            // 
            // textBoxPowerSupplyResetCounts
            // 
            this.textBoxPowerSupplyResetCounts.Location = new System.Drawing.Point(320, 413);
            this.textBoxPowerSupplyResetCounts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPowerSupplyResetCounts.Name = "textBoxPowerSupplyResetCounts";
            this.textBoxPowerSupplyResetCounts.Size = new System.Drawing.Size(90, 26);
            this.textBoxPowerSupplyResetCounts.TabIndex = 170;
            this.textBoxPowerSupplyResetCounts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPowerSupplyResetCounts_KeyDown_1);
            this.textBoxPowerSupplyResetCounts.Leave += new System.EventHandler(this.textBoxPowerSupplyResetCounts_Leave_1);
            // 
            // powerSupplyResetCountslabel
            // 
            this.powerSupplyResetCountslabel.AutoSize = true;
            this.powerSupplyResetCountslabel.Location = new System.Drawing.Point(56, 418);
            this.powerSupplyResetCountslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.powerSupplyResetCountslabel.Name = "powerSupplyResetCountslabel";
            this.powerSupplyResetCountslabel.Size = new System.Drawing.Size(207, 20);
            this.powerSupplyResetCountslabel.TabIndex = 169;
            this.powerSupplyResetCountslabel.Text = "Power Supply Reset Counts";
            // 
            // rangeLabel6
            // 
            this.rangeLabel6.AutoSize = true;
            this.rangeLabel6.Location = new System.Drawing.Point(546, 378);
            this.rangeLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel6.Name = "rangeLabel6";
            this.rangeLabel6.Size = new System.Drawing.Size(116, 20);
            this.rangeLabel6.TabIndex = 168;
            this.rangeLabel6.Text = "Range (0.1-72)";
            // 
            // textBoxBsrMeasurementTime
            // 
            this.textBoxBsrMeasurementTime.Location = new System.Drawing.Point(320, 373);
            this.textBoxBsrMeasurementTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBsrMeasurementTime.Name = "textBoxBsrMeasurementTime";
            this.textBoxBsrMeasurementTime.Size = new System.Drawing.Size(90, 26);
            this.textBoxBsrMeasurementTime.TabIndex = 167;
            this.textBoxBsrMeasurementTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBsrMeasurementTime_KeyDown_1);
            this.textBoxBsrMeasurementTime.Leave += new System.EventHandler(this.textBoxBsrMeasurementTime_Leave_1);
            // 
            // bsrMeasurementTimeLabel
            // 
            this.bsrMeasurementTimeLabel.AutoSize = true;
            this.bsrMeasurementTimeLabel.Location = new System.Drawing.Point(56, 378);
            this.bsrMeasurementTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bsrMeasurementTimeLabel.Name = "bsrMeasurementTimeLabel";
            this.bsrMeasurementTimeLabel.Size = new System.Drawing.Size(191, 20);
            this.bsrMeasurementTimeLabel.TabIndex = 165;
            this.bsrMeasurementTimeLabel.Text = "BSR Measurement Time  ";
            // 
            // rangeLabel5
            // 
            this.rangeLabel5.AutoSize = true;
            this.rangeLabel5.Location = new System.Drawing.Point(546, 337);
            this.rangeLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel5.Name = "rangeLabel5";
            this.rangeLabel5.Size = new System.Drawing.Size(103, 20);
            this.rangeLabel5.TabIndex = 164;
            this.rangeLabel5.Text = "Range (1-10)";
            // 
            // batteryCapacityLabel
            // 
            this.batteryCapacityLabel.AutoSize = true;
            this.batteryCapacityLabel.Location = new System.Drawing.Point(56, 253);
            this.batteryCapacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.batteryCapacityLabel.Name = "batteryCapacityLabel";
            this.batteryCapacityLabel.Size = new System.Drawing.Size(125, 20);
            this.batteryCapacityLabel.TabIndex = 163;
            this.batteryCapacityLabel.Text = "Battery Capacity";
            // 
            // textBoxRatioSlowFastTimer
            // 
            this.textBoxRatioSlowFastTimer.Location = new System.Drawing.Point(320, 332);
            this.textBoxRatioSlowFastTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRatioSlowFastTimer.Name = "textBoxRatioSlowFastTimer";
            this.textBoxRatioSlowFastTimer.Size = new System.Drawing.Size(90, 26);
            this.textBoxRatioSlowFastTimer.TabIndex = 162;
            this.textBoxRatioSlowFastTimer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRatioSlowFastTimer_KeyDown_1);
            this.textBoxRatioSlowFastTimer.Leave += new System.EventHandler(this.textBoxRatioSlowFastTimer_Leave_1);
            // 
            // ratioForSlowAndFastTimerLabel
            // 
            this.ratioForSlowAndFastTimerLabel.AutoSize = true;
            this.ratioForSlowAndFastTimerLabel.Location = new System.Drawing.Point(56, 337);
            this.ratioForSlowAndFastTimerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ratioForSlowAndFastTimerLabel.Name = "ratioForSlowAndFastTimerLabel";
            this.ratioForSlowAndFastTimerLabel.Size = new System.Drawing.Size(206, 20);
            this.ratioForSlowAndFastTimerLabel.TabIndex = 161;
            this.ratioForSlowAndFastTimerLabel.Text = "Ratio for slow and fast timer";
            // 
            // rangeLabel4
            // 
            this.rangeLabel4.AutoSize = true;
            this.rangeLabel4.Location = new System.Drawing.Point(546, 295);
            this.rangeLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel4.Name = "rangeLabel4";
            this.rangeLabel4.Size = new System.Drawing.Size(103, 20);
            this.rangeLabel4.TabIndex = 160;
            this.rangeLabel4.Text = "Range (1-10)";
            // 
            // rangeLabel3
            // 
            this.rangeLabel3.AutoSize = true;
            this.rangeLabel3.Location = new System.Drawing.Point(546, 253);
            this.rangeLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel3.Name = "rangeLabel3";
            this.rangeLabel3.Size = new System.Drawing.Size(116, 20);
            this.rangeLabel3.TabIndex = 159;
            this.rangeLabel3.Text = "Range (0.1-32)";
            // 
            // rangeLabel1
            // 
            this.rangeLabel1.AutoSize = true;
            this.rangeLabel1.Location = new System.Drawing.Point(546, 166);
            this.rangeLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel1.Name = "rangeLabel1";
            this.rangeLabel1.Size = new System.Drawing.Size(112, 20);
            this.rangeLabel1.TabIndex = 157;
            this.rangeLabel1.Text = "Range (10-32)";
            // 
            // rangeForPropertiesLabel
            // 
            this.rangeForPropertiesLabel.AutoSize = true;
            this.rangeForPropertiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeForPropertiesLabel.Location = new System.Drawing.Point(561, 34);
            this.rangeForPropertiesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeForPropertiesLabel.Name = "rangeForPropertiesLabel";
            this.rangeForPropertiesLabel.Size = new System.Drawing.Size(283, 40);
            this.rangeForPropertiesLabel.TabIndex = 156;
            this.rangeForPropertiesLabel.Text = "Accepted Range";
            // 
            // Topiclabel
            // 
            this.Topiclabel.AutoSize = true;
            this.Topiclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Topiclabel.Location = new System.Drawing.Point(53, 34);
            this.Topiclabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Topiclabel.Name = "Topiclabel";
            this.Topiclabel.Size = new System.Drawing.Size(293, 40);
            this.Topiclabel.TabIndex = 155;
            this.Topiclabel.Text = "Property Settings";
            // 
            // textBoxPeriodicInterrupTime
            // 
            this.textBoxPeriodicInterrupTime.Location = new System.Drawing.Point(320, 290);
            this.textBoxPeriodicInterrupTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPeriodicInterrupTime.Name = "textBoxPeriodicInterrupTime";
            this.textBoxPeriodicInterrupTime.Size = new System.Drawing.Size(90, 26);
            this.textBoxPeriodicInterrupTime.TabIndex = 154;
            this.textBoxPeriodicInterrupTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPeriodicInterrupTime_KeyDown_1);
            this.textBoxPeriodicInterrupTime.Leave += new System.EventHandler(this.textBoxPeriodicInterrupTime_Leave_1);
            // 
            // unitLabel5
            // 
            this.unitLabel5.AutoSize = true;
            this.unitLabel5.Location = new System.Drawing.Point(431, 295);
            this.unitLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel5.Name = "unitLabel5";
            this.unitLabel5.Size = new System.Drawing.Size(72, 20);
            this.unitLabel5.TabIndex = 153;
            this.unitLabel5.Text = "Seconds";
            // 
            // periodicInteruruptTimelabel
            // 
            this.periodicInteruruptTimelabel.AutoSize = true;
            this.periodicInteruruptTimelabel.Location = new System.Drawing.Point(56, 295);
            this.periodicInteruruptTimelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.periodicInteruruptTimelabel.Name = "periodicInteruruptTimelabel";
            this.periodicInteruruptTimelabel.Size = new System.Drawing.Size(168, 20);
            this.periodicInteruruptTimelabel.TabIndex = 152;
            this.periodicInteruruptTimelabel.Text = "Periodic Interrupt Time";
            // 
            // unitLabel4
            // 
            this.unitLabel4.AutoSize = true;
            this.unitLabel4.Location = new System.Drawing.Point(435, 253);
            this.unitLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel4.Name = "unitLabel4";
            this.unitLabel4.Size = new System.Drawing.Size(29, 20);
            this.unitLabel4.TabIndex = 151;
            this.unitLabel4.Text = "Ah";
            // 
            // textBoxBatteryCapacity
            // 
            this.textBoxBatteryCapacity.Location = new System.Drawing.Point(320, 247);
            this.textBoxBatteryCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBatteryCapacity.Name = "textBoxBatteryCapacity";
            this.textBoxBatteryCapacity.Size = new System.Drawing.Size(90, 26);
            this.textBoxBatteryCapacity.TabIndex = 150;
            this.textBoxBatteryCapacity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBatteryCapacity_KeyDown_1);
            this.textBoxBatteryCapacity.Leave += new System.EventHandler(this.textBoxBatteryCapacity_Leave_1);
            // 
            // unitLabel2
            // 
            this.unitLabel2.AutoSize = true;
            this.unitLabel2.Location = new System.Drawing.Point(431, 166);
            this.unitLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel2.Name = "unitLabel2";
            this.unitLabel2.Size = new System.Drawing.Size(56, 20);
            this.unitLabel2.TabIndex = 148;
            this.unitLabel2.Text = "mOhm";
            // 
            // unitLabel1
            // 
            this.unitLabel1.AutoSize = true;
            this.unitLabel1.Location = new System.Drawing.Point(435, 120);
            this.unitLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel1.Name = "unitLabel1";
            this.unitLabel1.Size = new System.Drawing.Size(69, 20);
            this.unitLabel1.TabIndex = 147;
            this.unitLabel1.Text = "Volts      ";
            // 
            // textBoxRsnsb
            // 
            this.textBoxRsnsb.Location = new System.Drawing.Point(320, 160);
            this.textBoxRsnsb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRsnsb.Name = "textBoxRsnsb";
            this.textBoxRsnsb.Size = new System.Drawing.Size(90, 26);
            this.textBoxRsnsb.TabIndex = 144;
            this.textBoxRsnsb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRsnsb_KeyDown_1);
            this.textBoxRsnsb.Leave += new System.EventHandler(this.textBoxRsnsb_Leave_1);
            // 
            // rsnsbLabel
            // 
            this.rsnsbLabel.AutoSize = true;
            this.rsnsbLabel.Location = new System.Drawing.Point(56, 166);
            this.rsnsbLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rsnsbLabel.Name = "rsnsbLabel";
            this.rsnsbLabel.Size = new System.Drawing.Size(69, 20);
            this.rsnsbLabel.TabIndex = 143;
            this.rsnsbLabel.Text = "RSNSB ";
            // 
            // comboBoxBatteryVoltage
            // 
            this.comboBoxBatteryVoltage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBatteryVoltage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxBatteryVoltage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxBatteryVoltage.FormattingEnabled = true;
            this.comboBoxBatteryVoltage.Items.AddRange(new object[] {
            "6",
            "12",
            "24"});
            this.comboBoxBatteryVoltage.Location = new System.Drawing.Point(320, 114);
            this.comboBoxBatteryVoltage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxBatteryVoltage.Name = "comboBoxBatteryVoltage";
            this.comboBoxBatteryVoltage.Size = new System.Drawing.Size(90, 28);
            this.comboBoxBatteryVoltage.TabIndex = 142;
            this.comboBoxBatteryVoltage.SelectedIndexChanged += new System.EventHandler(this.comboBoxBatteryVoltage_SelectedIndexChanged_1);
            this.comboBoxBatteryVoltage.Click += new System.EventHandler(this.comboBoxBatteryVoltage_Click);
            // 
            // batteryVoltageLabel
            // 
            this.batteryVoltageLabel.AutoSize = true;
            this.batteryVoltageLabel.Location = new System.Drawing.Point(56, 120);
            this.batteryVoltageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.batteryVoltageLabel.Name = "batteryVoltageLabel";
            this.batteryVoltageLabel.Size = new System.Drawing.Size(119, 20);
            this.batteryVoltageLabel.TabIndex = 140;
            this.batteryVoltageLabel.Text = "Battery Voltage";
            // 
            // ApplyChangesButton
            // 
            this.ApplyChangesButton.Location = new System.Drawing.Point(241, 1560);
            this.ApplyChangesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ApplyChangesButton.Name = "ApplyChangesButton";
            this.ApplyChangesButton.Size = new System.Drawing.Size(254, 66);
            this.ApplyChangesButton.TabIndex = 174;
            this.ApplyChangesButton.Text = "Apply Changes";
            this.ApplyChangesButton.UseVisualStyleBackColor = true;
            this.ApplyChangesButton.Click += new System.EventHandler(this.ApplyChangesButton_Click_1);
            // 
            // unitLabel8
            // 
            this.unitLabel8.AutoSize = true;
            this.unitLabel8.Location = new System.Drawing.Point(435, 458);
            this.unitLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel8.Name = "unitLabel8";
            this.unitLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.unitLabel8.Size = new System.Drawing.Size(56, 20);
            this.unitLabel8.TabIndex = 178;
            this.unitLabel8.Text = "mOhm";
            // 
            // rangeLabel8
            // 
            this.rangeLabel8.AutoSize = true;
            this.rangeLabel8.Location = new System.Drawing.Point(546, 458);
            this.rangeLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel8.Name = "rangeLabel8";
            this.rangeLabel8.Size = new System.Drawing.Size(121, 20);
            this.rangeLabel8.TabIndex = 177;
            this.rangeLabel8.Text = "Range (0-1000)";
            // 
            // textBoxBasicBSRHiAlert
            // 
            this.textBoxBasicBSRHiAlert.Location = new System.Drawing.Point(320, 453);
            this.textBoxBasicBSRHiAlert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBasicBSRHiAlert.Name = "textBoxBasicBSRHiAlert";
            this.textBoxBasicBSRHiAlert.Size = new System.Drawing.Size(90, 26);
            this.textBoxBasicBSRHiAlert.TabIndex = 176;
            this.textBoxBasicBSRHiAlert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBasicBSRHiAlert_KeyDown);
            this.textBoxBasicBSRHiAlert.Leave += new System.EventHandler(this.textBoxBasicBSRHiAlert_Leave);
            // 
            // basicBSRHiAlertlabel
            // 
            this.basicBSRHiAlertlabel.AutoSize = true;
            this.basicBSRHiAlertlabel.Location = new System.Drawing.Point(56, 458);
            this.basicBSRHiAlertlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.basicBSRHiAlertlabel.Name = "basicBSRHiAlertlabel";
            this.basicBSRHiAlertlabel.Size = new System.Drawing.Size(142, 20);
            this.basicBSRHiAlertlabel.TabIndex = 175;
            this.basicBSRHiAlertlabel.Text = "Basic BSR Hi Alert";
            // 
            // unitLabel9
            // 
            this.unitLabel9.AutoSize = true;
            this.unitLabel9.Location = new System.Drawing.Point(435, 500);
            this.unitLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel9.Name = "unitLabel9";
            this.unitLabel9.Size = new System.Drawing.Size(56, 20);
            this.unitLabel9.TabIndex = 182;
            this.unitLabel9.Text = "mOhm";
            // 
            // rangeLabel9
            // 
            this.rangeLabel9.AutoSize = true;
            this.rangeLabel9.Location = new System.Drawing.Point(546, 498);
            this.rangeLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel9.Name = "rangeLabel9";
            this.rangeLabel9.Size = new System.Drawing.Size(121, 20);
            this.rangeLabel9.TabIndex = 181;
            this.rangeLabel9.Text = "Range (0-1000)";
            // 
            // textBoxBasicBSRLoAlertLimit
            // 
            this.textBoxBasicBSRLoAlertLimit.Location = new System.Drawing.Point(320, 495);
            this.textBoxBasicBSRLoAlertLimit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBasicBSRLoAlertLimit.Name = "textBoxBasicBSRLoAlertLimit";
            this.textBoxBasicBSRLoAlertLimit.Size = new System.Drawing.Size(90, 26);
            this.textBoxBasicBSRLoAlertLimit.TabIndex = 180;
            this.textBoxBasicBSRLoAlertLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBasicBSRLoAlertLimit_KeyDown);
            this.textBoxBasicBSRLoAlertLimit.Leave += new System.EventHandler(this.textBoxBasicBSRLoAlertLimit_Leave);
            // 
            // BasicBsrLoAlertLimitlabel
            // 
            this.BasicBsrLoAlertLimitlabel.AutoSize = true;
            this.BasicBsrLoAlertLimitlabel.Location = new System.Drawing.Point(56, 500);
            this.BasicBsrLoAlertLimitlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BasicBsrLoAlertLimitlabel.Name = "BasicBsrLoAlertLimitlabel";
            this.BasicBsrLoAlertLimitlabel.Size = new System.Drawing.Size(182, 20);
            this.BasicBsrLoAlertLimitlabel.TabIndex = 179;
            this.BasicBsrLoAlertLimitlabel.Text = "Basic BSR Lo Alert Limit";
            // 
            // unitLabel10
            // 
            this.unitLabel10.AutoSize = true;
            this.unitLabel10.Location = new System.Drawing.Point(435, 541);
            this.unitLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel10.Name = "unitLabel10";
            this.unitLabel10.Size = new System.Drawing.Size(60, 20);
            this.unitLabel10.TabIndex = 185;
            this.unitLabel10.Text = "Celsius";
            // 
            // comboBoxDieTempHiAlertLimitTarget
            // 
            this.comboBoxDieTempHiAlertLimitTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDieTempHiAlertLimitTarget.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxDieTempHiAlertLimitTarget.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxDieTempHiAlertLimitTarget.FormattingEnabled = true;
            this.comboBoxDieTempHiAlertLimitTarget.Items.AddRange(new object[] {
            "20",
            "60",
            "80",
            "100"});
            this.comboBoxDieTempHiAlertLimitTarget.Location = new System.Drawing.Point(320, 535);
            this.comboBoxDieTempHiAlertLimitTarget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDieTempHiAlertLimitTarget.Name = "comboBoxDieTempHiAlertLimitTarget";
            this.comboBoxDieTempHiAlertLimitTarget.Size = new System.Drawing.Size(90, 28);
            this.comboBoxDieTempHiAlertLimitTarget.TabIndex = 184;
            this.comboBoxDieTempHiAlertLimitTarget.SelectedIndexChanged += new System.EventHandler(this.comboBoxDieTempHiAlertLimitTarget_SelectedIndexChanged);
            // 
            // dieTempHiAlertLimitTargetlabel
            // 
            this.dieTempHiAlertLimitTargetlabel.AutoSize = true;
            this.dieTempHiAlertLimitTargetlabel.Location = new System.Drawing.Point(56, 541);
            this.dieTempHiAlertLimitTargetlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dieTempHiAlertLimitTargetlabel.Name = "dieTempHiAlertLimitTargetlabel";
            this.dieTempHiAlertLimitTargetlabel.Size = new System.Drawing.Size(228, 20);
            this.dieTempHiAlertLimitTargetlabel.TabIndex = 183;
            this.dieTempHiAlertLimitTargetlabel.Text = "Die Temp Hi Alert Limit Target  ";
            // 
            // unitLabel11
            // 
            this.unitLabel11.AutoSize = true;
            this.unitLabel11.Location = new System.Drawing.Point(435, 581);
            this.unitLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel11.Name = "unitLabel11";
            this.unitLabel11.Size = new System.Drawing.Size(60, 20);
            this.unitLabel11.TabIndex = 189;
            this.unitLabel11.Text = "Celsius";
            // 
            // rangeLabel10
            // 
            this.rangeLabel10.AutoSize = true;
            this.rangeLabel10.Location = new System.Drawing.Point(546, 581);
            this.rangeLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel10.Name = "rangeLabel10";
            this.rangeLabel10.Size = new System.Drawing.Size(107, 20);
            this.rangeLabel10.TabIndex = 188;
            this.rangeLabel10.Text = "Range (0.5-5)";
            // 
            // dieTempHisteresisValueLabel
            // 
            this.dieTempHisteresisValueLabel.AutoSize = true;
            this.dieTempHisteresisValueLabel.Location = new System.Drawing.Point(56, 581);
            this.dieTempHisteresisValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dieTempHisteresisValueLabel.Name = "dieTempHisteresisValueLabel";
            this.dieTempHisteresisValueLabel.Size = new System.Drawing.Size(196, 20);
            this.dieTempHisteresisValueLabel.TabIndex = 186;
            this.dieTempHisteresisValueLabel.Text = "Die Temp Histeresis Value";
            // 
            // textBoxDieTempHisteresisValue
            // 
            this.textBoxDieTempHisteresisValue.Location = new System.Drawing.Point(320, 577);
            this.textBoxDieTempHisteresisValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDieTempHisteresisValue.Name = "textBoxDieTempHisteresisValue";
            this.textBoxDieTempHisteresisValue.Size = new System.Drawing.Size(90, 26);
            this.textBoxDieTempHisteresisValue.TabIndex = 190;
            this.textBoxDieTempHisteresisValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDieTempHisteresisValue_KeyDown);
            this.textBoxDieTempHisteresisValue.Leave += new System.EventHandler(this.textBoxDieTempHisteresisValue_Leave);
            // 
            // textBoxTRSTemperature
            // 
            this.textBoxTRSTemperature.Location = new System.Drawing.Point(320, 620);
            this.textBoxTRSTemperature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTRSTemperature.Name = "textBoxTRSTemperature";
            this.textBoxTRSTemperature.Size = new System.Drawing.Size(90, 26);
            this.textBoxTRSTemperature.TabIndex = 194;
            this.textBoxTRSTemperature.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTRSTemperature_KeyDown);
            this.textBoxTRSTemperature.Leave += new System.EventHandler(this.textBoxTRSTemperature_Leave);
            // 
            // unitLabel12
            // 
            this.unitLabel12.AutoSize = true;
            this.unitLabel12.Location = new System.Drawing.Point(435, 624);
            this.unitLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel12.Name = "unitLabel12";
            this.unitLabel12.Size = new System.Drawing.Size(60, 20);
            this.unitLabel12.TabIndex = 193;
            this.unitLabel12.Text = "Celsius";
            // 
            // rangeLabel11
            // 
            this.rangeLabel11.AutoSize = true;
            this.rangeLabel11.Location = new System.Drawing.Point(546, 624);
            this.rangeLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel11.Name = "rangeLabel11";
            this.rangeLabel11.Size = new System.Drawing.Size(121, 20);
            this.rangeLabel11.TabIndex = 192;
            this.rangeLabel11.Text = "Range (60-120)";
            // 
            // trsTemperatureLabel
            // 
            this.trsTemperatureLabel.AutoSize = true;
            this.trsTemperatureLabel.Location = new System.Drawing.Point(56, 624);
            this.trsTemperatureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trsTemperatureLabel.Name = "trsTemperatureLabel";
            this.trsTemperatureLabel.Size = new System.Drawing.Size(136, 20);
            this.trsTemperatureLabel.TabIndex = 191;
            this.trsTemperatureLabel.Text = "TRS Temperature";
            // 
            // textBoxTRETemperature
            // 
            this.textBoxTRETemperature.Location = new System.Drawing.Point(320, 660);
            this.textBoxTRETemperature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTRETemperature.Name = "textBoxTRETemperature";
            this.textBoxTRETemperature.Size = new System.Drawing.Size(90, 26);
            this.textBoxTRETemperature.TabIndex = 198;
            this.textBoxTRETemperature.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTRETemperature_KeyDown);
            this.textBoxTRETemperature.Leave += new System.EventHandler(this.textBoxTRETemperature_Leave);
            // 
            // unitLabel13
            // 
            this.unitLabel13.AutoSize = true;
            this.unitLabel13.Location = new System.Drawing.Point(435, 664);
            this.unitLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel13.Name = "unitLabel13";
            this.unitLabel13.Size = new System.Drawing.Size(60, 20);
            this.unitLabel13.TabIndex = 197;
            this.unitLabel13.Text = "Celsius";
            // 
            // rangeLabel12
            // 
            this.rangeLabel12.AutoSize = true;
            this.rangeLabel12.Location = new System.Drawing.Point(546, 664);
            this.rangeLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel12.Name = "rangeLabel12";
            this.rangeLabel12.Size = new System.Drawing.Size(121, 20);
            this.rangeLabel12.TabIndex = 196;
            this.rangeLabel12.Text = "Range (80-125)";
            // 
            // tretTemperatureLabel
            // 
            this.tretTemperatureLabel.AutoSize = true;
            this.tretTemperatureLabel.Location = new System.Drawing.Point(56, 664);
            this.tretTemperatureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tretTemperatureLabel.Name = "tretTemperatureLabel";
            this.tretTemperatureLabel.Size = new System.Drawing.Size(149, 20);
            this.tretTemperatureLabel.TabIndex = 195;
            this.tretTemperatureLabel.Text = "TRET Temperature ";
            // 
            // textBoxBasicBatteryVoltageLoAlertLimit
            // 
            this.textBoxBasicBatteryVoltageLoAlertLimit.Location = new System.Drawing.Point(320, 700);
            this.textBoxBasicBatteryVoltageLoAlertLimit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBasicBatteryVoltageLoAlertLimit.Name = "textBoxBasicBatteryVoltageLoAlertLimit";
            this.textBoxBasicBatteryVoltageLoAlertLimit.Size = new System.Drawing.Size(90, 26);
            this.textBoxBasicBatteryVoltageLoAlertLimit.TabIndex = 202;
            this.textBoxBasicBatteryVoltageLoAlertLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBasicBatteryVoltageLoAlertLimit_KeyDown);
            this.textBoxBasicBatteryVoltageLoAlertLimit.Leave += new System.EventHandler(this.textBoxBasicBatteryVoltageLoAlertLimit_Leave);
            // 
            // unitLabel14
            // 
            this.unitLabel14.AutoSize = true;
            this.unitLabel14.Location = new System.Drawing.Point(435, 704);
            this.unitLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel14.Name = "unitLabel14";
            this.unitLabel14.Size = new System.Drawing.Size(45, 20);
            this.unitLabel14.TabIndex = 201;
            this.unitLabel14.Text = "Volts";
            // 
            // basicBatteryVoltageLoAlertLimitLabel
            // 
            this.basicBatteryVoltageLoAlertLimitLabel.AutoSize = true;
            this.basicBatteryVoltageLoAlertLimitLabel.Location = new System.Drawing.Point(56, 704);
            this.basicBatteryVoltageLoAlertLimitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.basicBatteryVoltageLoAlertLimitLabel.Name = "basicBatteryVoltageLoAlertLimitLabel";
            this.basicBatteryVoltageLoAlertLimitLabel.Size = new System.Drawing.Size(266, 20);
            this.basicBatteryVoltageLoAlertLimitLabel.TabIndex = 199;
            this.basicBatteryVoltageLoAlertLimitLabel.Text = "Basic Battery Voltage Lo Alert Limit  ";
            // 
            // curRangeRSNSITextLabel
            // 
            this.curRangeRSNSITextLabel.AutoSize = true;
            this.curRangeRSNSITextLabel.Location = new System.Drawing.Point(546, 209);
            this.curRangeRSNSITextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curRangeRSNSITextLabel.Name = "curRangeRSNSITextLabel";
            this.curRangeRSNSITextLabel.Size = new System.Drawing.Size(126, 20);
            this.curRangeRSNSITextLabel.TabIndex = 204;
            this.curRangeRSNSITextLabel.Text = "Current Range : ";
            // 
            // curRangeRSNSIValueLabel
            // 
            this.curRangeRSNSIValueLabel.AutoSize = true;
            this.curRangeRSNSIValueLabel.Location = new System.Drawing.Point(682, 209);
            this.curRangeRSNSIValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curRangeRSNSIValueLabel.Name = "curRangeRSNSIValueLabel";
            this.curRangeRSNSIValueLabel.Size = new System.Drawing.Size(21, 20);
            this.curRangeRSNSIValueLabel.TabIndex = 205;
            this.curRangeRSNSIValueLabel.Text = "...";
            // 
            // curRangeBasicVoltageLoAlertLimitValueLabel
            // 
            this.curRangeBasicVoltageLoAlertLimitValueLabel.AutoSize = true;
            this.curRangeBasicVoltageLoAlertLimitValueLabel.Location = new System.Drawing.Point(682, 704);
            this.curRangeBasicVoltageLoAlertLimitValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curRangeBasicVoltageLoAlertLimitValueLabel.Name = "curRangeBasicVoltageLoAlertLimitValueLabel";
            this.curRangeBasicVoltageLoAlertLimitValueLabel.Size = new System.Drawing.Size(21, 20);
            this.curRangeBasicVoltageLoAlertLimitValueLabel.TabIndex = 207;
            this.curRangeBasicVoltageLoAlertLimitValueLabel.Text = "...";
            // 
            // curRangeBasicVoltageLoAlertLimitTextLabel
            // 
            this.curRangeBasicVoltageLoAlertLimitTextLabel.AutoSize = true;
            this.curRangeBasicVoltageLoAlertLimitTextLabel.Location = new System.Drawing.Point(546, 704);
            this.curRangeBasicVoltageLoAlertLimitTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curRangeBasicVoltageLoAlertLimitTextLabel.Name = "curRangeBasicVoltageLoAlertLimitTextLabel";
            this.curRangeBasicVoltageLoAlertLimitTextLabel.Size = new System.Drawing.Size(126, 20);
            this.curRangeBasicVoltageLoAlertLimitTextLabel.TabIndex = 206;
            this.curRangeBasicVoltageLoAlertLimitTextLabel.Text = "Current Range : ";
            // 
            // unitLabel3
            // 
            this.unitLabel3.AutoSize = true;
            this.unitLabel3.Location = new System.Drawing.Point(431, 209);
            this.unitLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel3.Name = "unitLabel3";
            this.unitLabel3.Size = new System.Drawing.Size(56, 20);
            this.unitLabel3.TabIndex = 149;
            this.unitLabel3.Text = "mOhm";
            // 
            // textBoxRsnsi
            // 
            this.textBoxRsnsi.Location = new System.Drawing.Point(320, 203);
            this.textBoxRsnsi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRsnsi.Name = "textBoxRsnsi";
            this.textBoxRsnsi.Size = new System.Drawing.Size(90, 26);
            this.textBoxRsnsi.TabIndex = 146;
            this.textBoxRsnsi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRsnsi_KeyDown);
            this.textBoxRsnsi.Leave += new System.EventHandler(this.textBoxRsnsi_Leave_1);
            // 
            // rsnsiLabel
            // 
            this.rsnsiLabel.AutoSize = true;
            this.rsnsiLabel.Location = new System.Drawing.Point(56, 209);
            this.rsnsiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rsnsiLabel.Name = "rsnsiLabel";
            this.rsnsiLabel.Size = new System.Drawing.Size(63, 20);
            this.rsnsiLabel.TabIndex = 145;
            this.rsnsiLabel.Text = "RSNSI ";
            // 
            // unitLabel6
            // 
            this.unitLabel6.AutoSize = true;
            this.unitLabel6.Location = new System.Drawing.Point(435, 378);
            this.unitLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel6.Name = "unitLabel6";
            this.unitLabel6.Size = new System.Drawing.Size(52, 20);
            this.unitLabel6.TabIndex = 166;
            this.unitLabel6.Text = "Hours";
            // 
            // curRangeBasicVoltageHiAlertLimitTextLabel
            // 
            this.curRangeBasicVoltageHiAlertLimitTextLabel.AutoSize = true;
            this.curRangeBasicVoltageHiAlertLimitTextLabel.Location = new System.Drawing.Point(546, 741);
            this.curRangeBasicVoltageHiAlertLimitTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curRangeBasicVoltageHiAlertLimitTextLabel.Name = "curRangeBasicVoltageHiAlertLimitTextLabel";
            this.curRangeBasicVoltageHiAlertLimitTextLabel.Size = new System.Drawing.Size(126, 20);
            this.curRangeBasicVoltageHiAlertLimitTextLabel.TabIndex = 211;
            this.curRangeBasicVoltageHiAlertLimitTextLabel.Text = "Current Range : ";
            // 
            // textBoxBasicBatteryVoltageHiAlertLimit
            // 
            this.textBoxBasicBatteryVoltageHiAlertLimit.Location = new System.Drawing.Point(320, 737);
            this.textBoxBasicBatteryVoltageHiAlertLimit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBasicBatteryVoltageHiAlertLimit.Name = "textBoxBasicBatteryVoltageHiAlertLimit";
            this.textBoxBasicBatteryVoltageHiAlertLimit.Size = new System.Drawing.Size(90, 26);
            this.textBoxBasicBatteryVoltageHiAlertLimit.TabIndex = 210;
            this.textBoxBasicBatteryVoltageHiAlertLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBasicBatteryVoltageHiAlertLimit_KeyDown);
            this.textBoxBasicBatteryVoltageHiAlertLimit.Leave += new System.EventHandler(this.textBoxBasicBatteryVoltageHiAlertLimit_Leave);
            // 
            // unitLabel15
            // 
            this.unitLabel15.AutoSize = true;
            this.unitLabel15.Location = new System.Drawing.Point(435, 741);
            this.unitLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel15.Name = "unitLabel15";
            this.unitLabel15.Size = new System.Drawing.Size(45, 20);
            this.unitLabel15.TabIndex = 209;
            this.unitLabel15.Text = "Volts";
            // 
            // basicBatteryVoltageHiAlertLimitLabel
            // 
            this.basicBatteryVoltageHiAlertLimitLabel.AutoSize = true;
            this.basicBatteryVoltageHiAlertLimitLabel.Location = new System.Drawing.Point(56, 741);
            this.basicBatteryVoltageHiAlertLimitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.basicBatteryVoltageHiAlertLimitLabel.Name = "basicBatteryVoltageHiAlertLimitLabel";
            this.basicBatteryVoltageHiAlertLimitLabel.Size = new System.Drawing.Size(263, 20);
            this.basicBatteryVoltageHiAlertLimitLabel.TabIndex = 208;
            this.basicBatteryVoltageHiAlertLimitLabel.Text = "Basic Battery Voltage Hi Alert Limit  ";
            // 
            // curRangeBasicVoltageHiAlertLimitValueLabel
            // 
            this.curRangeBasicVoltageHiAlertLimitValueLabel.AutoSize = true;
            this.curRangeBasicVoltageHiAlertLimitValueLabel.Location = new System.Drawing.Point(682, 740);
            this.curRangeBasicVoltageHiAlertLimitValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curRangeBasicVoltageHiAlertLimitValueLabel.Name = "curRangeBasicVoltageHiAlertLimitValueLabel";
            this.curRangeBasicVoltageHiAlertLimitValueLabel.Size = new System.Drawing.Size(21, 20);
            this.curRangeBasicVoltageHiAlertLimitValueLabel.TabIndex = 213;
            this.curRangeBasicVoltageHiAlertLimitValueLabel.Text = "...";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 773);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 26);
            this.textBox1.TabIndex = 217;
            // 
            // unitLabel16
            // 
            this.unitLabel16.AutoSize = true;
            this.unitLabel16.Location = new System.Drawing.Point(435, 777);
            this.unitLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel16.Name = "unitLabel16";
            this.unitLabel16.Size = new System.Drawing.Size(60, 20);
            this.unitLabel16.TabIndex = 216;
            this.unitLabel16.Text = "Celsius";
            // 
            // rangeLabel13
            // 
            this.rangeLabel13.AutoSize = true;
            this.rangeLabel13.Location = new System.Drawing.Point(546, 777);
            this.rangeLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel13.Name = "rangeLabel13";
            this.rangeLabel13.Size = new System.Drawing.Size(121, 20);
            this.rangeLabel13.TabIndex = 215;
            this.rangeLabel13.Text = "Range (80-125)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 777);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 214;
            this.label4.Text = "label";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(320, 809);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 26);
            this.textBox2.TabIndex = 221;
            // 
            // unitLabel17
            // 
            this.unitLabel17.AutoSize = true;
            this.unitLabel17.Location = new System.Drawing.Point(435, 813);
            this.unitLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel17.Name = "unitLabel17";
            this.unitLabel17.Size = new System.Drawing.Size(60, 20);
            this.unitLabel17.TabIndex = 220;
            this.unitLabel17.Text = "Celsius";
            // 
            // rangeLabel14
            // 
            this.rangeLabel14.AutoSize = true;
            this.rangeLabel14.Location = new System.Drawing.Point(546, 813);
            this.rangeLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel14.Name = "rangeLabel14";
            this.rangeLabel14.Size = new System.Drawing.Size(121, 20);
            this.rangeLabel14.TabIndex = 219;
            this.rangeLabel14.Text = "Range (80-125)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 813);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 218;
            this.label7.Text = "TRET Temperature ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(320, 845);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 26);
            this.textBox3.TabIndex = 225;
            // 
            // unitLabel18
            // 
            this.unitLabel18.AutoSize = true;
            this.unitLabel18.Location = new System.Drawing.Point(435, 849);
            this.unitLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel18.Name = "unitLabel18";
            this.unitLabel18.Size = new System.Drawing.Size(60, 20);
            this.unitLabel18.TabIndex = 224;
            this.unitLabel18.Text = "Celsius";
            // 
            // rangeLabel15
            // 
            this.rangeLabel15.AutoSize = true;
            this.rangeLabel15.Location = new System.Drawing.Point(546, 849);
            this.rangeLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel15.Name = "rangeLabel15";
            this.rangeLabel15.Size = new System.Drawing.Size(121, 20);
            this.rangeLabel15.TabIndex = 223;
            this.rangeLabel15.Text = "Range (80-125)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 849);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 20);
            this.label10.TabIndex = 222;
            this.label10.Text = "TRET Temperature ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(320, 881);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 26);
            this.textBox4.TabIndex = 229;
            // 
            // unitLabel19
            // 
            this.unitLabel19.AutoSize = true;
            this.unitLabel19.Location = new System.Drawing.Point(435, 885);
            this.unitLabel19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel19.Name = "unitLabel19";
            this.unitLabel19.Size = new System.Drawing.Size(60, 20);
            this.unitLabel19.TabIndex = 228;
            this.unitLabel19.Text = "Celsius";
            // 
            // rangeLabel16
            // 
            this.rangeLabel16.AutoSize = true;
            this.rangeLabel16.Location = new System.Drawing.Point(546, 885);
            this.rangeLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel16.Name = "rangeLabel16";
            this.rangeLabel16.Size = new System.Drawing.Size(121, 20);
            this.rangeLabel16.TabIndex = 227;
            this.rangeLabel16.Text = "Range (80-125)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(56, 885);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 20);
            this.label13.TabIndex = 226;
            this.label13.Text = "TRET Temperature ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(320, 917);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(90, 26);
            this.textBox5.TabIndex = 233;
            // 
            // unitLabel20
            // 
            this.unitLabel20.AutoSize = true;
            this.unitLabel20.Location = new System.Drawing.Point(435, 921);
            this.unitLabel20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel20.Name = "unitLabel20";
            this.unitLabel20.Size = new System.Drawing.Size(60, 20);
            this.unitLabel20.TabIndex = 232;
            this.unitLabel20.Text = "Celsius";
            // 
            // rangeLabel17
            // 
            this.rangeLabel17.AutoSize = true;
            this.rangeLabel17.Location = new System.Drawing.Point(546, 921);
            this.rangeLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel17.Name = "rangeLabel17";
            this.rangeLabel17.Size = new System.Drawing.Size(121, 20);
            this.rangeLabel17.TabIndex = 231;
            this.rangeLabel17.Text = "Range (80-125)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(56, 921);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 20);
            this.label16.TabIndex = 230;
            this.label16.Text = "TRET Temperature ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(320, 953);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(90, 26);
            this.textBox6.TabIndex = 237;
            // 
            // unitLabel21
            // 
            this.unitLabel21.AutoSize = true;
            this.unitLabel21.Location = new System.Drawing.Point(435, 957);
            this.unitLabel21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel21.Name = "unitLabel21";
            this.unitLabel21.Size = new System.Drawing.Size(60, 20);
            this.unitLabel21.TabIndex = 236;
            this.unitLabel21.Text = "Celsius";
            // 
            // rangeLabel18
            // 
            this.rangeLabel18.AutoSize = true;
            this.rangeLabel18.Location = new System.Drawing.Point(546, 957);
            this.rangeLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel18.Name = "rangeLabel18";
            this.rangeLabel18.Size = new System.Drawing.Size(121, 20);
            this.rangeLabel18.TabIndex = 235;
            this.rangeLabel18.Text = "Range (80-125)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(56, 957);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(149, 20);
            this.label19.TabIndex = 234;
            this.label19.Text = "TRET Temperature ";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(320, 989);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(90, 26);
            this.textBox7.TabIndex = 241;
            // 
            // unitLabel22
            // 
            this.unitLabel22.AutoSize = true;
            this.unitLabel22.Location = new System.Drawing.Point(435, 993);
            this.unitLabel22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel22.Name = "unitLabel22";
            this.unitLabel22.Size = new System.Drawing.Size(60, 20);
            this.unitLabel22.TabIndex = 240;
            this.unitLabel22.Text = "Celsius";
            // 
            // rangeLabel19
            // 
            this.rangeLabel19.AutoSize = true;
            this.rangeLabel19.Location = new System.Drawing.Point(546, 993);
            this.rangeLabel19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel19.Name = "rangeLabel19";
            this.rangeLabel19.Size = new System.Drawing.Size(121, 20);
            this.rangeLabel19.TabIndex = 239;
            this.rangeLabel19.Text = "Range (80-125)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(56, 993);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(149, 20);
            this.label22.TabIndex = 238;
            this.label22.Text = "TRET Temperature ";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(320, 1025);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(90, 26);
            this.textBox8.TabIndex = 245;
            // 
            // unitLabel23
            // 
            this.unitLabel23.AutoSize = true;
            this.unitLabel23.Location = new System.Drawing.Point(435, 1029);
            this.unitLabel23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel23.Name = "unitLabel23";
            this.unitLabel23.Size = new System.Drawing.Size(60, 20);
            this.unitLabel23.TabIndex = 244;
            this.unitLabel23.Text = "Celsius";
            // 
            // rangeLabel20
            // 
            this.rangeLabel20.AutoSize = true;
            this.rangeLabel20.Location = new System.Drawing.Point(546, 1029);
            this.rangeLabel20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel20.Name = "rangeLabel20";
            this.rangeLabel20.Size = new System.Drawing.Size(121, 20);
            this.rangeLabel20.TabIndex = 243;
            this.rangeLabel20.Text = "Range (80-125)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(56, 1029);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(149, 20);
            this.label25.TabIndex = 242;
            this.label25.Text = "TRET Temperature ";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1012, 1050);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.unitLabel23);
            this.Controls.Add(this.rangeLabel20);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.unitLabel22);
            this.Controls.Add(this.rangeLabel19);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.unitLabel21);
            this.Controls.Add(this.rangeLabel18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.unitLabel20);
            this.Controls.Add(this.rangeLabel17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.unitLabel19);
            this.Controls.Add(this.rangeLabel16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.unitLabel18);
            this.Controls.Add(this.rangeLabel15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.unitLabel17);
            this.Controls.Add(this.rangeLabel14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.unitLabel16);
            this.Controls.Add(this.rangeLabel13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.curRangeBasicVoltageHiAlertLimitValueLabel);
            this.Controls.Add(this.curRangeBasicVoltageHiAlertLimitTextLabel);
            this.Controls.Add(this.textBoxBasicBatteryVoltageHiAlertLimit);
            this.Controls.Add(this.unitLabel15);
            this.Controls.Add(this.basicBatteryVoltageHiAlertLimitLabel);
            this.Controls.Add(this.rsnsbLabel);
            this.Controls.Add(this.textBoxRsnsb);
            this.Controls.Add(this.unitLabel2);
            this.Controls.Add(this.rsnsiLabel);
            this.Controls.Add(this.unitLabel4);
            this.Controls.Add(this.textBoxRsnsi);
            this.Controls.Add(this.textBoxBatteryCapacity);
            this.Controls.Add(this.unitLabel3);
            this.Controls.Add(this.batteryCapacityLabel);
            this.Controls.Add(this.curRangeBasicVoltageLoAlertLimitValueLabel);
            this.Controls.Add(this.curRangeBasicVoltageLoAlertLimitTextLabel);
            this.Controls.Add(this.curRangeRSNSIValueLabel);
            this.Controls.Add(this.curRangeRSNSITextLabel);
            this.Controls.Add(this.textBoxBasicBatteryVoltageLoAlertLimit);
            this.Controls.Add(this.unitLabel14);
            this.Controls.Add(this.basicBatteryVoltageLoAlertLimitLabel);
            this.Controls.Add(this.textBoxTRETemperature);
            this.Controls.Add(this.unitLabel13);
            this.Controls.Add(this.rangeLabel12);
            this.Controls.Add(this.tretTemperatureLabel);
            this.Controls.Add(this.textBoxTRSTemperature);
            this.Controls.Add(this.unitLabel12);
            this.Controls.Add(this.rangeLabel11);
            this.Controls.Add(this.trsTemperatureLabel);
            this.Controls.Add(this.textBoxDieTempHisteresisValue);
            this.Controls.Add(this.unitLabel11);
            this.Controls.Add(this.rangeLabel10);
            this.Controls.Add(this.dieTempHisteresisValueLabel);
            this.Controls.Add(this.unitLabel10);
            this.Controls.Add(this.comboBoxDieTempHiAlertLimitTarget);
            this.Controls.Add(this.dieTempHiAlertLimitTargetlabel);
            this.Controls.Add(this.unitLabel9);
            this.Controls.Add(this.rangeLabel9);
            this.Controls.Add(this.textBoxBasicBSRLoAlertLimit);
            this.Controls.Add(this.BasicBsrLoAlertLimitlabel);
            this.Controls.Add(this.unitLabel8);
            this.Controls.Add(this.rangeLabel8);
            this.Controls.Add(this.textBoxBasicBSRHiAlert);
            this.Controls.Add(this.basicBSRHiAlertlabel);
            this.Controls.Add(this.ApplyChangesButton);
            this.Controls.Add(this.unitLabel7);
            this.Controls.Add(this.rangeLabel7);
            this.Controls.Add(this.textBoxPowerSupplyResetCounts);
            this.Controls.Add(this.powerSupplyResetCountslabel);
            this.Controls.Add(this.rangeLabel6);
            this.Controls.Add(this.textBoxBsrMeasurementTime);
            this.Controls.Add(this.unitLabel6);
            this.Controls.Add(this.bsrMeasurementTimeLabel);
            this.Controls.Add(this.rangeLabel5);
            this.Controls.Add(this.textBoxRatioSlowFastTimer);
            this.Controls.Add(this.ratioForSlowAndFastTimerLabel);
            this.Controls.Add(this.rangeLabel4);
            this.Controls.Add(this.rangeLabel3);
            this.Controls.Add(this.rangeLabel1);
            this.Controls.Add(this.rangeForPropertiesLabel);
            this.Controls.Add(this.Topiclabel);
            this.Controls.Add(this.textBoxPeriodicInterrupTime);
            this.Controls.Add(this.unitLabel5);
            this.Controls.Add(this.periodicInteruruptTimelabel);
            this.Controls.Add(this.unitLabel1);
            this.Controls.Add(this.comboBoxBatteryVoltage);
            this.Controls.Add(this.batteryVoltageLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Battery Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label unitLabel7;
        private System.Windows.Forms.Label rangeLabel7;
        private System.Windows.Forms.TextBox textBoxPowerSupplyResetCounts;
        private System.Windows.Forms.Label powerSupplyResetCountslabel;
        private System.Windows.Forms.Label rangeLabel6;
        private System.Windows.Forms.TextBox textBoxBsrMeasurementTime;
        private System.Windows.Forms.Label bsrMeasurementTimeLabel;
        private System.Windows.Forms.Label rangeLabel5;
        private Label batteryCapacityLabel;
        private System.Windows.Forms.Label periodicInteruruptTimelabel;
        private System.Windows.Forms.TextBox textBoxRatioSlowFastTimer;
        private System.Windows.Forms.Label ratioForSlowAndFastTimerLabel;
        private System.Windows.Forms.Label rangeLabel4;
        private System.Windows.Forms.Label rangeLabel3;
        private System.Windows.Forms.Label rangeLabel1;
        private System.Windows.Forms.Label rangeForPropertiesLabel;
        private System.Windows.Forms.Label Topiclabel;
        private System.Windows.Forms.TextBox textBoxPeriodicInterrupTime;
        private System.Windows.Forms.Label unitLabel5;
        private System.Windows.Forms.Label unitLabel4;
        private System.Windows.Forms.TextBox textBoxBatteryCapacity;
        private System.Windows.Forms.Label unitLabel2;
        private System.Windows.Forms.Label unitLabel1;
        private System.Windows.Forms.TextBox textBoxRsnsb;
        private System.Windows.Forms.Label rsnsbLabel;
        private System.Windows.Forms.ComboBox comboBoxBatteryVoltage;
        private System.Windows.Forms.Label batteryVoltageLabel;
        private System.Windows.Forms.Button ApplyChangesButton;
        private System.Windows.Forms.Label unitLabel8;
        private System.Windows.Forms.Label rangeLabel8;
        private System.Windows.Forms.TextBox textBoxBasicBSRHiAlert;
        private System.Windows.Forms.Label basicBSRHiAlertlabel;
        private System.Windows.Forms.Label unitLabel9;
        private System.Windows.Forms.Label rangeLabel9;
        private System.Windows.Forms.TextBox textBoxBasicBSRLoAlertLimit;
        private System.Windows.Forms.Label BasicBsrLoAlertLimitlabel;
        private System.Windows.Forms.Label unitLabel10;
        private System.Windows.Forms.ComboBox comboBoxDieTempHiAlertLimitTarget;
        private System.Windows.Forms.Label dieTempHiAlertLimitTargetlabel;
        private System.Windows.Forms.Label unitLabel11;
        private System.Windows.Forms.Label rangeLabel10;
        private System.Windows.Forms.Label dieTempHisteresisValueLabel;
        private System.Windows.Forms.TextBox textBoxDieTempHisteresisValue;
        private System.Windows.Forms.TextBox textBoxTRSTemperature;
        private System.Windows.Forms.Label unitLabel12;
        private System.Windows.Forms.Label rangeLabel11;
        private System.Windows.Forms.Label trsTemperatureLabel;
        private System.Windows.Forms.TextBox textBoxTRETemperature;
        private System.Windows.Forms.Label unitLabel13;
        private System.Windows.Forms.Label rangeLabel12;
        private System.Windows.Forms.Label tretTemperatureLabel;
        private System.Windows.Forms.TextBox textBoxBasicBatteryVoltageLoAlertLimit;
        private System.Windows.Forms.Label unitLabel14;
        private System.Windows.Forms.Label basicBatteryVoltageLoAlertLimitLabel;
        private System.Windows.Forms.Label curRangeRSNSITextLabel;
        private System.Windows.Forms.Label curRangeRSNSIValueLabel;
        private System.Windows.Forms.Label curRangeBasicVoltageLoAlertLimitValueLabel;
        private System.Windows.Forms.Label curRangeBasicVoltageLoAlertLimitTextLabel;
        private System.Windows.Forms.Label unitLabel3;
        private System.Windows.Forms.TextBox textBoxRsnsi;
        private System.Windows.Forms.Label rsnsiLabel;
        private System.Windows.Forms.Label unitLabel6;
        private Label curRangeBasicVoltageHiAlertLimitTextLabel;
        private TextBox textBoxBasicBatteryVoltageHiAlertLimit;
        private Label unitLabel15;
        private Label basicBatteryVoltageHiAlertLimitLabel;
        private Label curRangeBasicVoltageHiAlertLimitValueLabel;
        private TextBox textBox1;
        private Label unitLabel16;
        private Label rangeLabel13;
        private Label label4;
        private TextBox textBox2;
        private Label unitLabel17;
        private Label rangeLabel14;
        private Label label7;
        private TextBox textBox3;
        private Label unitLabel18;
        private Label rangeLabel15;
        private Label label10;
        private TextBox textBox4;
        private Label unitLabel19;
        private Label rangeLabel16;
        private Label label13;
        private TextBox textBox5;
        private Label unitLabel20;
        private Label rangeLabel17;
        private Label label16;
        private TextBox textBox6;
        private Label unitLabel21;
        private Label rangeLabel18;
        private Label label19;
        private TextBox textBox7;
        private Label unitLabel22;
        private Label rangeLabel19;
        private Label label22;
        private TextBox textBox8;
        private Label unitLabel23;
        private Label rangeLabel20;
        private Label label25;
    }
}

