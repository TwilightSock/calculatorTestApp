using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConverterLib 
{
    public static class TemperatureUnit
    {
        public static class FromCelsius 
        {
            public static double ConvertTo(Temperature unit, double num)
            {
                switch (unit)
                {
                    case Temperature.Celsius:
                        return num;
                    case Temperature.Fahrenheit:
                        return (num * 9/5) + 32;
                    case Temperature.Kelvin:
                        return num + 273.15;
                    default:
                        return 0;
                }

            }
        }

        public static class FromFahrenheit 
        {
            public static double ConvertTo(Temperature unit, double num)
            {
                switch (unit)
                {
                    case Temperature.Celsius:
                        return (num -32) * 5/9;
                    case Temperature.Fahrenheit:
                        return num ;
                    case Temperature.Kelvin:
                        return (num - 32) * 5/9 +273.15;
                    default:
                        return 0;
                }

            }
        }

        public static class FromKelvin
        {
            public static double ConvertTo(Temperature unit, double num)
            {
                switch (unit)
                {
                    case Temperature.Celsius:
                        return num - 273.15;
                    case Temperature.Fahrenheit:
                        return (num - 273.15) * 9/5 +32;
                    case Temperature.Kelvin:
                        return num;
                    default:
                        return 0;
                }

            }
        }
    }

}
