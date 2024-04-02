using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoInterfaceFormsApp
{
    internal enum PropertiesEnum
    {
        [Description("Battery voltage")]
        BatteryVoltage,
        [Description("RSNSB")]
        RSNSB,
        [Description("RSNSI")]
        RSNSI,
        [Description("Battery capacity")]
        BatteryCapacity,
        [Description("Periodic interrupt time")]
        PeriodicInterruptTime,
        [Description("Ratio for slow and fast timer")]
        RatioSlowFastTimer,
        [Description("Basic slow timer time")]
        BasicSlowTimerTime,
        [Description("BSR measurement time")]
        BSRMeasurementTime,
        [Description("Power supply reset counts")]
        PowerSupplyResetCounts,
        [Description("Basic BSR hi alert")]
        BasicBSRHiAlert,
        [Description("Basic BSR lo alert limit")]
        BasicBSRLoAlertLimit,
        [Description("Die temp hi alert limit target")]
        DieTempHiAlertLimitTarget,
        [Description("Die temp histeresis value")]
        DieTempHisteresisValue,
        [Description("TRS temperature")]
        TRSTemperature,
        [Description("TRET temperature")]
        TRETTemperature,
        [Description("Basic battery voltage lo alert limit")]
        BasicBatteryVoltageLoAlertLimit,
        [Description("Basic battery voltage hi alert limit")]
        BasicBatteryVoltageHiAlertLimit,
        [Description("Basic vbat histeresis value")]
        BasicVbatHisteresisValue,
        [Description("Basic vcharge setting")]
        BasicVchargeSetting,
        [Description("Basic vabsorb delta setting")]
        BasicVabsorbDeltaSetting,
        [Description("Basic vequalize delta setting")]
        BasicVequalizeDeltaSetting,
        [Description("Basic battery current lo alert limit")]
        BasicBatteryCurrentLoAlertLlimit,
        [Description("Basic ibat histeresis value")]
        BasicIbatHisteresisValue,
        [Description("C over X ratio")]
        COverXRratio
    }

    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
