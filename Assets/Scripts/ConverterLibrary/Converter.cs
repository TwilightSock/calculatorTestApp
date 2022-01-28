using System.Collections;
using System.Collections.Generic;


namespace ConverterLib
{
    public enum Length
    {
        Millimeter,
        Centimeter,
        Meter,
        Kilometer,
        Mile,
        Inch,
        Feet,
        Yard,
        unknown
    }

    public enum Temperature
    {
        Celsius,
        Fahrenheit,
        Kelvin,
        unknown
    }
    public static class Converter
    {
        public static Length ParceStringToUnit(string unitName)
        {
            unitName = unitName.ToLower();
            switch (unitName)
            {
                case "cm":
                    return Length.Centimeter;
                case "mm":
                    return Length.Millimeter;
                case "m":
                    return Length.Meter;
                case "km":
                    return Length.Kilometer;
                case "mi":
                    return Length.Mile;
                case "in":
                    return Length.Inch;
                case "ft":
                    return Length.Feet;
                case "yd":
                    return Length.Yard;
                default:
                    return Length.unknown;
            }
        }

        public static Temperature ParceStringToUnitTemperature(string unitName)
        {
            unitName = unitName.ToLower();
            switch (unitName)
            {
                case "celsius":
                    return Temperature.Celsius;
                case "fahrenheit":
                    return Temperature.Fahrenheit;
                case "kelvin":
                    return Temperature.Kelvin;
                default:
                    return Temperature.unknown;
            }
        }

        public static double UnitConverterLength(Length from, Length to, decimal value)
        {
            switch (from) 
            {
                case Length.Millimeter:
                    return LengthUnit.FromMillimeter.ConvertTo(to,(double)value);
                case Length.Centimeter:
                    return LengthUnit.FromCentimeter.ConvertTo(to, (double)value);
                case Length.Meter:
                    return LengthUnit.FromMeter.ConvertTo(to, (double)value);
                case Length.Kilometer:
                    return LengthUnit.FromKilometer.ConvertTo(to, (double)value);
                case Length.Mile:
                    return LengthUnit.FromMile.ConvertTo(to, (double)value);
                case Length.Inch:
                    return LengthUnit.FromInch.ConvertTo(to, (double)value);
                case Length.Feet:
                    return LengthUnit.FromFeet.ConvertTo(to, (double)value);
                case Length.Yard:
                    return LengthUnit.FromYard.ConvertTo(to, (double)value);
                default:
                    throw new System.Exception("unknown unit");
            }
            
        }

        public static double UnitConverterTemperature(Temperature from, Temperature to, decimal value)
        {
            switch (from)
            {
                case Temperature.Celsius:
                    return TemperatureUnit.FromCelsius.ConvertTo(to, (double)value);
                case Temperature.Fahrenheit:
                    return TemperatureUnit.FromFahrenheit.ConvertTo(to, (double)value);
                case Temperature.Kelvin:
                    return TemperatureUnit.FromKelvin.ConvertTo(to, (double)value);
                default:
                    throw new System.Exception("unknown unit");
            }

        }


    }

}


