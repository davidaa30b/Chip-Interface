using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ArduinoInterfaceFormsApp.PropertiesEnum;
using static ArduinoInterfaceFormsApp.Constants;

namespace ArduinoInterfaceFormsApp
{
    public partial class Form1 : Form
    {
        //constants

        private double nVoltageParameter = 2;

        private List<double> listBatteryVoltageValues = new List<double> { 6, 12, 24 };
        private List<double> listDieTempHiAlertLimitTargets = new List<double> { 20, 60, 80, 100 };

        //keys
        private string previousValueBatteryVol = "";
        private bool batteryVoltageSelectKey = true, handlingSelectionChange = false;
        private bool neverSeeAgainBatteryVoltageWarning = false, canChangeBatteryVoltage = false;
        
        //source file
        private string filePath = "";

        //properties
        static private BmsPropertySettings batteryVoltage = new BmsPropertySettings(BatteryVoltage, 12, "battery_Voltage");
        static private BmsPropertySettings rsnsb = new BmsPropertySettings(RSNSB,10, "RSNSB");
        static private BmsPropertySettings rsnsi = new BmsPropertySettings(RSNSI,10, "RSNSI");
        static private BmsPropertySettings batteryCapacity = new BmsPropertySettings(BatteryCapacity, 18000000, "batteryCapacity");
        static private BmsPropertySettings periodicInterruptTime = new BmsPropertySettings(PeriodicInterruptTime, 1000, "periodic_Interrupt_time_ms");
        static private BmsPropertySettings ratioSlowFastTimer = new BmsPropertySettings(RatioSlowFastTimer, 5, "");//not included
        static private BmsPropertySettings basicSlowTimerTime = new BmsPropertySettings(BasicSlowTimerTime, 5000, "basic_slow_timer1_time_ms");
        static private BmsPropertySettings bsrMeasurementTime = new BmsPropertySettings(BSRMeasurementTime, 3600, "bsr_measurement_time_in_seconds");
        static private BmsPropertySettings powerSupplyResetCounts = new BmsPropertySettings(PowerSupplyResetCounts, 100, "powerSepply_reset_counts");
        static private BmsPropertySettings basicBSRHiAlert = new BmsPropertySettings(BasicBSRHiAlert, 400, "basic_bsr_hi_alert_limit");
        static private BmsPropertySettings basicBSRLoAlertLimit = new BmsPropertySettings(BasicBSRLoAlertLimit, 20, "basic_bsr_lo_alert_limit");
        static private BmsPropertySettings dieTempHiAlertLimitTarget = new BmsPropertySettings(DieTempHiAlertLimitTarget, 16018, "die_temp_hi_alert_limit_target");
        static private BmsPropertySettings dieTempHisteresisValue = new BmsPropertySettings(DieTempHisteresisValue, 232, "die_temp_histeresis_value");
        static private BmsPropertySettings trsTemperature = new BmsPropertySettings(TRSTemperature, 120, "TRS_Temperature_Celsius");
        static private BmsPropertySettings tretTemperature = new BmsPropertySettings(TRETTemperature, 125, "TRET_Temperature_Celsius");
        static private BmsPropertySettings basicBatteryVoltageLoAlertLimit = new BmsPropertySettings(BasicBatteryVoltageLoAlertLimit, 5000000, "basic_battery_Voltage_lo_alert_limit");
        static private BmsPropertySettings basicBatteryVoltageHiAlertLimit = new BmsPropertySettings(BasicBatteryVoltageHiAlertLimit, 7000000, "basic_battery_Voltage_hi_alert_limit");
        
        BmsPropertySettings[] propertiesArray = new BmsPropertySettings[] {
            batteryVoltage, rsnsb, rsnsi, batteryCapacity, periodicInterruptTime,
            bsrMeasurementTime, powerSupplyResetCounts, basicBSRHiAlert, basicBSRLoAlertLimit,
            dieTempHiAlertLimitTarget, dieTempHisteresisValue, trsTemperature, tretTemperature,
            basicBatteryVoltageLoAlertLimit, basicBatteryVoltageHiAlertLimit
        };
        public Form1()
        {
            InitializeComponent();

            // Create a ToolTip instance
            ToolTip toolTip = new ToolTip();

            // Set the ToolTip text for each label
            toolTip.SetToolTip(curRangeRSNSITextLabel, "Battery Voltage aka (BV) : \r\nBV=6 range (1-20),BV=12 range (1-10),BV=24 range (1-5)\r\n");
            toolTip.SetToolTip(curRangeBasicVoltageLoAlertLimitTextLabel, "Range (5*N-5.5*N) ,  where Battery Voltage aka \r\n(BV)  : BV=6 N=1, BV=12 N=2, BV=24 N=4\r\n");
            toolTip.SetToolTip(curRangeBasicVoltageHiAlertLimitTextLabel, "Range (5.5*N-7*N) ,  where Battery Voltage aka \r\n(BV)  : BV=6 N=1, BV=12 N=2, BV=24 N=4\r\n");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //default values!!
            comboBoxBatteryVoltage.Text = batteryVoltage.getValue().ToString();
            textBoxRsnsb.Text = rsnsb.getValue().ToString();
            textBoxBatteryCapacity.Text = (batteryCapacity.getValue()/ MILLI).ToString();
            textBoxPeriodicInterrupTime.Text = (periodicInterruptTime.getValue()/THOU).ToString();
            textBoxRatioSlowFastTimer.Text = ratioSlowFastTimer.getValue().ToString();
            textBoxBsrMeasurementTime.Text = (bsrMeasurementTime.getValue()/SECS).ToString();
            textBoxPowerSupplyResetCounts.Text = (powerSupplyResetCounts.getValue() * TEN).ToString();
            textBoxBasicBSRHiAlert.Text = basicBSRHiAlert.getValue().ToString();
            textBoxBasicBSRLoAlertLimit.Text = basicBSRLoAlertLimit.getValue().ToString();
            comboBoxDieTempHiAlertLimitTarget.Text = listDieTempHiAlertLimitTargets[2].ToString();
            textBoxDieTempHisteresisValue.Text = Math.Round(dieTempHisteresisValue.getValue()/TEMP_H,2).ToString();
            textBoxTRSTemperature.Text = trsTemperature.getValue().ToString();
            textBoxTRETemperature.Text = tretTemperature.getValue().ToString();

            //range set up!!                      
            rsnsb.setRange(10,32);
            batteryCapacity.setRange(0.1, 32);
            periodicInterruptTime.setRange(1, 10);
            ratioSlowFastTimer.setRange(1, 10);
            bsrMeasurementTime.setRange(0.1, 72);
            powerSupplyResetCounts.setRange(500,5000);
            basicBSRHiAlert.setRange(0, 1000);
            basicBSRLoAlertLimit.setRange(0, 1000);
            dieTempHisteresisValue.setRange(0.5,5);
            trsTemperature.setRange(60, 120);
            tretTemperature.setRange(80, 125);
            //range label set up!!

            rangeLabel1.Text = rsnsb.getRange();
            rangeLabel3.Text = batteryCapacity.getRange();
            rangeLabel4.Text = periodicInterruptTime.getRange();
            rangeLabel5.Text = ratioSlowFastTimer.getRange();
            rangeLabel6.Text = bsrMeasurementTime.getRange();
            rangeLabel7.Text = powerSupplyResetCounts.getRange();
            rangeLabel8.Text = basicBSRHiAlert.getRange();
            rangeLabel9.Text = basicBSRLoAlertLimit.getRange();
            rangeLabel10.Text = dieTempHisteresisValue.getRange();
            rangeLabel11.Text = trsTemperature.getRange();
            rangeLabel12.Text = tretTemperature.getRange();
            


            //set up unit!!
            batteryVoltage.setUnit("Volts");
            rsnsb.setUnit("mOhm");
            rsnsi.setUnit("mOhm");
            batteryCapacity.setUnit("Ah");
            periodicInterruptTime.setUnit("Seconds");
            bsrMeasurementTime.setUnit("Hours");
            powerSupplyResetCounts.setUnit("Milliseconds");
            basicBSRHiAlert.setUnit("mOhm");
            basicBSRLoAlertLimit.setUnit("mOhm");
            dieTempHiAlertLimitTarget.setUnit("Celsius");
            dieTempHisteresisValue.setUnit("Celsius");
            trsTemperature.setUnit("Celsius");
            tretTemperature.setUnit("Celsius");
            basicBatteryVoltageLoAlertLimit.setUnit("Volts");
            basicBatteryVoltageHiAlertLimit.setUnit("Volts");

            //label unit set up!!

            unitLabel1.Text = batteryVoltage.getUnit();
            unitLabel2.Text = rsnsb.getUnit();
            unitLabel3.Text = rsnsi.getUnit();
            unitLabel4.Text = batteryCapacity.getUnit();
            unitLabel5.Text = periodicInterruptTime.getUnit();
            unitLabel6.Text = bsrMeasurementTime.getUnit();
            unitLabel7.Text = powerSupplyResetCounts.getUnit();
            unitLabel8.Text = basicBSRHiAlert.getUnit();
            unitLabel9.Text = basicBSRLoAlertLimit.getUnit();
            unitLabel10.Text = dieTempHiAlertLimitTarget.getUnit();
            unitLabel11.Text = dieTempHisteresisValue.getUnit();
            unitLabel12.Text = trsTemperature.getUnit();
            unitLabel13.Text = tretTemperature.getUnit();
            unitLabel14.Text = basicBatteryVoltageLoAlertLimit.getUnit();
            unitLabel15.Text = basicBatteryVoltageHiAlertLimit.getUnit();


            //label name set up!!
            batteryVoltageLabel.Text = batteryVoltage.getName().GetDescription();
            rsnsbLabel.Text = rsnsb.getName().GetDescription();
            rsnsiLabel.Text = rsnsi.getName().GetDescription();
            batteryCapacityLabel.Text = batteryCapacity.getName().GetDescription();
            periodicInteruruptTimelabel.Text = periodicInterruptTime.getName().GetDescription();
            ratioForSlowAndFastTimerLabel.Text = ratioSlowFastTimer.getName().GetDescription();
            bsrMeasurementTimeLabel.Text = bsrMeasurementTime.getName().GetDescription();
            powerSupplyResetCountslabel.Text = powerSupplyResetCounts.getName().GetDescription();
            basicBSRHiAlertlabel.Text = basicBSRHiAlert.getName().GetDescription();
            BasicBsrLoAlertLimitlabel.Text = basicBSRLoAlertLimit.getName().GetDescription();
            dieTempHiAlertLimitTargetlabel.Text = dieTempHiAlertLimitTarget.getName().GetDescription();
            dieTempHisteresisValueLabel.Text = dieTempHisteresisValue.getName().GetDescription();
            trsTemperatureLabel.Text = trsTemperature.getName().GetDescription();
            tretTemperatureLabel.Text = tretTemperature.getName().GetDescription();
            basicBatteryVoltageLoAlertLimitLabel.Text = basicBatteryVoltageLoAlertLimit.getName().GetDescription();
            basicBatteryVoltageHiAlertLimitLabel.Text = basicBatteryVoltageHiAlertLimit.getName().GetDescription();
        }


        private void ApplyChangesButton_Click_1(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox> { textBoxRsnsb,textBoxRsnsi, textBoxBatteryCapacity, textBoxPeriodicInterrupTime, textBoxRatioSlowFastTimer,
            textBoxBsrMeasurementTime,textBoxPowerSupplyResetCounts,textBoxBasicBSRHiAlert,textBoxBasicBSRLoAlertLimit,textBoxDieTempHisteresisValue,
            textBoxTRSTemperature,textBoxTRETemperature,textBoxBasicBatteryVoltageLoAlertLimit,textBoxBasicBatteryVoltageHiAlertLimit};

            bool anyEmptyTextBox = textBoxes.Any(textBox => string.IsNullOrEmpty(textBox.Text)) ;
            bool anyInvalidTextBox = textBoxes.Any(textBox => textBox.BackColor == Color.Red);
            if (anyEmptyTextBox)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (anyInvalidTextBox)
            {
                MessageBox.Show("Please correct all fields out of range.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ValidateInput(TextBox textBox,BmsPropertySettings property)
        {

            PropertiesEnum name = property.getName();
            // Parse the text as an integer
            if (!double.TryParse(textBox.Text, out double value) && textBox.Text!="")
            {
                MessageBox.Show("Invalid input. Please enter a valid numberic value for "+ property + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox.Text = ""; 
                return;
            }

            switch (name)
            {
                case RSNSB:
                    if (property.outOfRange())
                    {
                        //MessageBox.Show("Input value for "+ property + " must be in the range (10 , 32).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //textBox.Text = "";
                        rsnsbLabel.BackColor = Color.Red;
                        textBoxRsnsb.BackColor = Color.Red;
                    }
                    else
                    {
                        rsnsbLabel.BackColor = Color.Transparent;
                        textBoxRsnsb.BackColor = Color.White;
                        rsnsb.setValue(value);
                    }
                    break;
                case RSNSI:
                    if (((batteryVoltage.getValue() == listBatteryVoltageValues[0] && value > 20) || 
                         (batteryVoltage.getValue() == listBatteryVoltageValues[1] && value > 10) ||
                         (batteryVoltage.getValue() == listBatteryVoltageValues[2] && value > 5)) ||
                         (value < 1))
                    {                     
                        rsnsiLabel.BackColor = Color.Red;
                        textBoxRsnsi.BackColor = Color.Red;
                    }
                    else
                    {
                        rsnsiLabel.BackColor = Color.Transparent;
                        textBoxRsnsi.BackColor = Color.White;
                        rsnsi.setValue(value);
                    }
                    break;
                case BatteryCapacity:
                    if (property.outOfRange())
                    {
                        
                        batteryCapacityLabel.BackColor = Color.Red;
                        textBoxBatteryCapacity.BackColor = Color.Red;
                    }
                    else
                    {
                        batteryCapacityLabel.BackColor = Color.Transparent;
                        textBoxBatteryCapacity.BackColor = Color.White;
                        batteryCapacity.setValue(value*MILLI);
                    }
                    break;
                case PeriodicInterruptTime:
                    if (property.outOfRange())
                    {
                        periodicInteruruptTimelabel.BackColor = Color.Red;
                        textBoxPeriodicInterrupTime.BackColor = Color.Red;
                    }
                    else
                    {

                        periodicInteruruptTimelabel.BackColor = Color.Transparent;
                        textBoxPeriodicInterrupTime.BackColor = Color.White;
                        periodicInterruptTime.setValue(value*THOU);
                    }
                    break;
                case RatioSlowFastTimer:
                    if (property.outOfRange())
                    {
                        
                        ratioForSlowAndFastTimerLabel.BackColor = Color.Red;
                        textBoxRatioSlowFastTimer.BackColor = Color.Red;
                    }
                    else
                    {
                        ratioForSlowAndFastTimerLabel.BackColor = Color.Transparent;
                        textBoxRatioSlowFastTimer.BackColor = Color.White;
                        basicSlowTimerTime.setValue(periodicInterruptTime.getValue() * ratioSlowFastTimer.getValue());
                    }
                    break;
                case BSRMeasurementTime:
                    if (property.outOfRange())
                    {
                        
                        bsrMeasurementTimeLabel.BackColor = Color.Red;
                        textBoxBsrMeasurementTime.BackColor = Color.Red;
                    }
                    else
                    {
                        bsrMeasurementTimeLabel.BackColor = Color.Transparent;
                        textBoxBsrMeasurementTime.BackColor = Color.White;
                        bsrMeasurementTime.setValue(value * SECS);
                    }
                    break;
                case PowerSupplyResetCounts:
                    if (property.outOfRange())
                    {
                       

                        powerSupplyResetCountslabel.BackColor = Color.Red;
                        textBoxPowerSupplyResetCounts.BackColor = Color.Red;
                    }
                    else
                    {

                        powerSupplyResetCountslabel.BackColor = Color.Transparent;
                        textBoxPowerSupplyResetCounts.BackColor = Color.White;
                        powerSupplyResetCounts.setValue(value/TEN);
                    }
                    break;
                case BasicBSRHiAlert:
                    if (property.outOfRange())
                    {
                       

                        basicBSRHiAlertlabel.BackColor = Color.Red;
                        textBoxBasicBSRHiAlert.BackColor = Color.Red;
                    }
                    else
                    {
                        basicBSRHiAlertlabel.BackColor = Color.Transparent;
                        textBoxBasicBSRHiAlert.BackColor = Color.White;
                        basicBSRHiAlert.setValue(value);
                    }
                    break;
                case BasicBSRLoAlertLimit:
                    if (property.outOfRange())
                    {

                        BasicBsrLoAlertLimitlabel.BackColor = Color.Red;
                        textBoxBasicBSRLoAlertLimit.BackColor = Color.Red;
                    }
                    else
                    {
                        BasicBsrLoAlertLimitlabel.BackColor = Color.Transparent;
                        textBoxBasicBSRLoAlertLimit.BackColor = Color.White;
                        basicBSRLoAlertLimit.setValue(value);
                    }
                    break;
                case DieTempHisteresisValue:
                    if (property.outOfRange())
                    {

                        dieTempHisteresisValueLabel.BackColor = Color.Red;
                        textBoxDieTempHisteresisValue.BackColor = Color.Red;
                    }
                    else
                    {
                        dieTempHisteresisValueLabel.BackColor = Color.Transparent;
                        textBoxDieTempHisteresisValue.BackColor = Color.White;
                        dieTempHisteresisValue.setValue(value*TEMP_H);
                    }
                    break;
                case TRSTemperature:
                    if (property.outOfRange())
                    {
                        

                        trsTemperatureLabel.BackColor = Color.Red;
                        textBoxTRSTemperature.BackColor = Color.Red;
                    }
                    else
                    {
                        trsTemperatureLabel.BackColor = Color.Transparent;
                        textBoxTRSTemperature.BackColor = Color.White;
                        trsTemperature.setValue(value);
                    }
                    break;
                case TRETTemperature:
                    if (property.outOfRange())
                    {
                        tretTemperatureLabel.BackColor = Color.Red;
                        textBoxTRETemperature.BackColor = Color.Red;
                    }
                    else
                    {
                        tretTemperatureLabel.BackColor = Color.Transparent;
                        textBoxTRETemperature.BackColor = Color.White;
                        tretTemperature.setValue(value);
                    }
                    break;
                case BasicBatteryVoltageLoAlertLimit:
                    if (value < (5 * nVoltageParameter) || value >  (5.5 * nVoltageParameter))
                    {
                        basicBatteryVoltageLoAlertLimitLabel.BackColor = Color.Red;
                        textBoxBasicBatteryVoltageLoAlertLimit.BackColor = Color.Red;
                    }
                    else
                    {
                        basicBatteryVoltageLoAlertLimitLabel.BackColor = Color.Transparent;
                        textBoxBasicBatteryVoltageLoAlertLimit.BackColor = Color.White;
                        basicBatteryVoltageLoAlertLimit.setValue(value*MILLI/nVoltageParameter);
                    }
                    break;
                case BasicBatteryVoltageHiAlertLimit:
                    if (value < (5.5*nVoltageParameter) || value > (7 * nVoltageParameter))
                    {
                        basicBatteryVoltageHiAlertLimitLabel.BackColor = Color.Red;
                        textBoxBasicBatteryVoltageHiAlertLimit.BackColor = Color.Red;
                    }
                    else
                    {
                        basicBatteryVoltageHiAlertLimitLabel.BackColor = Color.Transparent;
                        textBoxBasicBatteryVoltageHiAlertLimit.BackColor = Color.White;
                        basicBatteryVoltageHiAlertLimit.setValue(value*MILLI/nVoltageParameter);
                    }
                    break;
                default:
                    break;
            }
                
            
        }


        private void textBoxRsnsb_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateInput(textBoxRsnsb, rsnsb);
            }
        }
        private void textBoxRsnsb_Leave_1(object sender, EventArgs e)
        {
            ValidateInput(textBoxRsnsb, rsnsb);

        }

        private void comboBoxBatteryVoltage_Click(object sender, EventArgs e)
        {
            previousValueBatteryVol = comboBoxBatteryVoltage.Text;
        }

        private void comboBoxBatteryVoltage_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (handlingSelectionChange)
                return;


            canChangeBatteryVoltage = false;
            DialogResult comboBoxBatteryVoltageDialogRes = DialogResult.None;

            if (!neverSeeAgainBatteryVoltageWarning && !batteryVoltageSelectKey)
            {
                comboBoxBatteryVoltageDialogRes = MessageBox.Show(
                    "New selected value for [Battery Voltage] will reset\n" +
                    "[RSNSI], [Basic Battery Voltage Lo Alert Limit] and \n" +
                    "[Basic Battery Voltage Hi Alert Limit] to their \n" +
                    "default values. Would you like to continue?\n" +
                    "If you do not want to see this message again select\n" +
                    "'Cancel'.", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            }

            if (comboBoxBatteryVoltageDialogRes == DialogResult.Cancel)
            {
                neverSeeAgainBatteryVoltageWarning = true;
            }
            else if (comboBoxBatteryVoltageDialogRes == DialogResult.Yes)
            {
                canChangeBatteryVoltage = true;
            }
            else if (comboBoxBatteryVoltageDialogRes == DialogResult.No)
            {
                handlingSelectionChange = true; // Set the flag to prevent retriggering the event
                comboBoxBatteryVoltage.Text = previousValueBatteryVol;
                handlingSelectionChange = false; // Reset the flag after changing the ComboBox text

            }

            if (canChangeBatteryVoltage || neverSeeAgainBatteryVoltageWarning || batteryVoltageSelectKey)
            {
                batteryVoltage.setValue(int.Parse(comboBoxBatteryVoltage.Text));

                switch (batteryVoltage.getValue())
                {
                    case 6:    
                        textBoxRsnsi.Text = "20";
                        nVoltageParameter = 1;
                        curRangeRSNSIValueLabel.Text = "(1-20)";
                        break;
                    case 12:           
                        textBoxRsnsi.Text = "10";
                        nVoltageParameter = 2;
                        curRangeRSNSIValueLabel.Text = "(1-10)";                     
                        break;
                    case 24:                     
                        textBoxRsnsi.Text = "5";
                        nVoltageParameter = 4;
                        curRangeRSNSIValueLabel.Text = "(1-5)";                                              
                        break;
                }

                rsnsiLabel.BackColor = Color.Transparent;
                textBoxRsnsi.BackColor = Color.White;

                curRangeBasicVoltageLoAlertLimitValueLabel.Text = "(" + (5 * nVoltageParameter).ToString() + "-" + (5.5 * nVoltageParameter).ToString() + ")";
                basicBatteryVoltageLoAlertLimitLabel.BackColor = Color.Transparent;
                textBoxBasicBatteryVoltageLoAlertLimit.BackColor = Color.White;
                textBoxBasicBatteryVoltageLoAlertLimit.Text = (basicBatteryVoltageLoAlertLimit.getValue() * nVoltageParameter / MILLI).ToString();

                curRangeBasicVoltageHiAlertLimitValueLabel.Text = "(" + (5.5 * nVoltageParameter).ToString() + "-" + (7 * nVoltageParameter).ToString() + ")";
                basicBatteryVoltageHiAlertLimitLabel.BackColor = Color.Transparent;
                textBoxBasicBatteryVoltageHiAlertLimit.BackColor = Color.White;
                textBoxBasicBatteryVoltageHiAlertLimit.Text = (basicBatteryVoltageHiAlertLimit.getValue() * nVoltageParameter / MILLI).ToString();

                batteryVoltageSelectKey = false;
                canChangeBatteryVoltage = false;
            }
             
        }

        private void textBoxBasicBSRHiAlert_Leave(object sender, EventArgs e)
        {
            ValidateInput(textBoxBasicBSRHiAlert, basicBSRHiAlert);
        }

        private void textBoxBasicBSRHiAlert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateInput(textBoxBasicBSRHiAlert, basicBSRHiAlert);
            }
        }

        private void textBoxBasicBSRLoAlertLimit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateInput(textBoxBasicBSRLoAlertLimit, basicBSRLoAlertLimit);
            }
        }

        private void textBoxBasicBSRLoAlertLimit_Leave(object sender, EventArgs e)
        {
            ValidateInput(textBoxBasicBSRLoAlertLimit, basicBSRLoAlertLimit);
        }

        private void textBoxRsnsi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateInput(textBoxRsnsi, rsnsi);
            }
        }

        private void textBoxRsnsi_Leave_1(object sender, EventArgs e)
        {
            ValidateInput(textBoxRsnsi, rsnsi);
        }

        private void textBoxBatteryCapacity_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateInput(textBoxBatteryCapacity, batteryCapacity);
            }
        }

        private void textBoxBatteryCapacity_Leave_1(object sender, EventArgs e)
        {
            ValidateInput(textBoxBatteryCapacity, batteryCapacity);
        }

        private void textBoxPeriodicInterrupTime_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateInput(textBoxPeriodicInterrupTime, periodicInterruptTime);
            }
        }

        private void textBoxPeriodicInterrupTime_Leave_1(object sender, EventArgs e)
        {
            ValidateInput(textBoxPeriodicInterrupTime, periodicInterruptTime);
        }

        private void textBoxRatioSlowFastTimer_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateInput(textBoxRatioSlowFastTimer, ratioSlowFastTimer);
            }
        }

        private void textBoxRatioSlowFastTimer_Leave_1(object sender, EventArgs e)
        {
            ValidateInput(textBoxRatioSlowFastTimer, ratioSlowFastTimer);
        }

        private void textBoxBsrMeasurementTime_Leave_1(object sender, EventArgs e)
        {
            ValidateInput(textBoxBsrMeasurementTime, bsrMeasurementTime);

            
        }

        private void textBoxBsrMeasurementTime_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateInput(textBoxBsrMeasurementTime, bsrMeasurementTime);
            }
        }

        private void textBoxPowerSupplyResetCounts_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateInput(textBoxPowerSupplyResetCounts, powerSupplyResetCounts);
            }

        }

        private void textBoxPowerSupplyResetCounts_Leave_1(object sender, EventArgs e)
        {
            ValidateInput(textBoxPowerSupplyResetCounts, powerSupplyResetCounts);
        }
   
        private void comboBoxDieTempHiAlertLimitTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            dieTempHiAlertLimitTarget.setValue(int.Parse(comboBoxDieTempHiAlertLimitTarget.Text));

            switch (dieTempHiAlertLimitTarget.getValue())
            {
                case 20:
                    dieTempHiAlertLimitTarget.setValue(13227);
                    break;
                case 60:
                    dieTempHiAlertLimitTarget.setValue(15088);
                    break;
                case 80:
                    dieTempHiAlertLimitTarget.setValue(16018);
                    break;
                case 100:
                    dieTempHiAlertLimitTarget.setValue(18948);
                    break;
            }
        }

        private void textBoxDieTempHisteresisValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateInput(textBoxDieTempHisteresisValue, dieTempHisteresisValue);
            }
        }

        private void textBoxDieTempHisteresisValue_Leave(object sender, EventArgs e)
        {
            ValidateInput(textBoxDieTempHisteresisValue, dieTempHisteresisValue);
        }

        private void textBoxTRSTemperature_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateInput(textBoxTRSTemperature, trsTemperature);
            }
        }

        private void textBoxTRSTemperature_Leave(object sender, EventArgs e)
        {
            ValidateInput(textBoxTRSTemperature, trsTemperature);

        }

        private void textBoxTRETemperature_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateInput(textBoxTRETemperature, tretTemperature);
            }
        }

        private void textBoxTRETemperature_Leave(object sender, EventArgs e)
        {
            ValidateInput(textBoxTRETemperature, tretTemperature);
        }

        private void textBoxBasicBatteryVoltageHiAlertLimit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateInput(textBoxBasicBatteryVoltageHiAlertLimit, basicBatteryVoltageHiAlertLimit);
            }
        }

        private void textBoxBasicBatteryVoltageHiAlertLimit_Leave(object sender, EventArgs e)
        {
            ValidateInput(textBoxBasicBatteryVoltageHiAlertLimit, basicBatteryVoltageHiAlertLimit);
        }

        private void textBoxBasicBatteryVoltageLoAlertLimit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateInput(textBoxBasicBatteryVoltageLoAlertLimit, basicBatteryVoltageLoAlertLimit);
            }
        }

      

        private void textBoxBasicBatteryVoltageLoAlertLimit_Leave(object sender, EventArgs e)
        {
            ValidateInput(textBoxBasicBatteryVoltageLoAlertLimit, basicBatteryVoltageLoAlertLimit);

        }

      
    }
}
