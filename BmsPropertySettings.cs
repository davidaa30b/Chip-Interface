using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArduinoInterfaceFormsApp.PropertiesEnum;
using static ArduinoInterfaceFormsApp.Constants;

namespace ArduinoInterfaceFormsApp
{

    internal class BmsPropertySettings
    {
        private double value;
        private PropertiesEnum name;
        private string scriptName;
        private Range range;
        private string unit;

        public BmsPropertySettings(PropertiesEnum name,double value,string scriptName) 
        {
            this.name = name;
            this.value = value;
            this.scriptName = scriptName;
        }

        public string getUnit()
        {
            return unit;
        }

        public void setUnit(string unit)
        {
            this.unit = unit;
        }

        public void setRange(double lowerBound,double upperBound)
        {
            Range range = new Range(lowerBound,upperBound);
            this.range = range;
        }

        public string getRange()
        {
            return "Range : " + range.ToString();
        }

        public PropertiesEnum getName()
        {
            return name;
        }

        public double getTransformedValue()
        {
            switch (name)
            {
                case BatteryCapacity:
                    value = value / MILLI;
                    break;

            }
            return value;
        }
        public double getValue()
        {
            return value;
        }
        
        public void setValue(double value)
        {
            this.value = value;
        }

        public string getScriptName()
        {
            return scriptName;
        }

        public void setScriptName(string scriptName)
        {
            this.scriptName = scriptName;
        }

        public bool outOfRange()
        {
            return range.outOfRange(value);
        }

        private class Range
        {
            private double upperBound;
            private double lowerBound;

            public Range(double lowerBound, double upperBound)
            {
                this.upperBound = upperBound;
                this.lowerBound = lowerBound;
            }

            public bool outOfRange(double value)
            {
                return value < lowerBound || value > upperBound;
            }

            public override string ToString()
            {
                return "(" + lowerBound  + " - "  + upperBound + ")";
            }
        }


    }

    
}
