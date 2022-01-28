using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConverterLib 
{
    public static class LengthUnit 
    {
        public static class FromMillimeter 
        {
            public static double ConvertTo(Length unit, double num) 
            {
                switch (unit) 
                {
                    case Length.Millimeter:
                        return num;
                    case Length.Centimeter:
                       return num * 0.1;
                    case Length.Meter:
                        return num * 0.001;
                    case Length.Kilometer:
                        return num * 0.000001;
                    case Length.Mile:
                        return num * 0.0000006213;
                    case Length.Inch:
                        return num * 0.03937;
                    case Length.Feet:
                        return num * 0.003281;
                    case Length.Yard:
                        return num * 0.001094;
                    default:
                        return 0;
                }

            }
        }

        public static class FromCentimeter
        {
            public static double ConvertTo(Length unit, double num)
            {
                switch (unit)
                {
                    case Length.Millimeter:
                        return num * 10;
                    case Length.Centimeter:
                        return num;
                    case Length.Meter:
                        return num * 0.01;
                    case Length.Kilometer:
                        return num * 0.00001;
                    case Length.Mile:
                        return num * 0.000006213;
                    case Length.Inch:
                        return num * 0.3937;
                    case Length.Feet:
                        return num * 0.03281;
                    case Length.Yard:
                        return num * 0.01094;
                    default:
                        return 0;
                }

            }
        }

        public static class FromMeter
        {
            public static double ConvertTo(Length unit, double num)
            {
                switch (unit)
                {
                    case Length.Millimeter:
                        return num * 1000;
                    case Length.Centimeter:
                        return num * 100;
                    case Length.Meter:
                        return num;
                    case Length.Kilometer:
                        return num * 0.001;
                    case Length.Mile:
                        return num * 0.0006213;
                    case Length.Inch:
                        return num * 39.37;
                    case Length.Feet:
                        return num * 3.281;
                    case Length.Yard:
                        return num * 1.094;
                    default:
                        return 0;
                }

            }
        }

        public static class FromKilometer
        {
            public static double ConvertTo(Length unit, double num)
            {
                switch (unit)
                {
                    case Length.Millimeter:
                        return num * 1000000;
                    case Length.Centimeter:
                        return num * 100000;
                    case Length.Meter:
                        return num * 1000;
                    case Length.Kilometer:
                        return num;
                    case Length.Mile:
                        return num * 0.621371;
                    case Length.Inch:
                        return num * 39370.08;
                    case Length.Feet:
                        return num * 3281;
                    case Length.Yard:
                        return num * 1094;
                    default:
                        return 0;
                }

            }
        }

        public static class FromMile
        {
            public static double ConvertTo(Length unit, double num)
            {
                switch (unit)
                {
                    case Length.Millimeter:
                        return num * 1609344;
                    case Length.Centimeter:
                        return num * 160934.4;
                    case Length.Meter:
                        return num * 1609.344;
                    case Length.Kilometer:
                        return num * 1.609344;
                    case Length.Mile:
                        return num;
                    case Length.Inch:
                        return num * 63360;
                    case Length.Feet:
                        return num * 5280;
                    case Length.Yard:
                        return num * 1760;
                    default:
                        return 0;
                }

            }

        }

        public static class FromInch
        {
            public static double ConvertTo(Length unit, double num)
            {
                switch (unit)
                {
                    case Length.Millimeter:
                        return num * 25.4;
                    case Length.Centimeter:
                        return num * 2.54;
                    case Length.Meter:
                        return num * 0.0254;
                    case Length.Kilometer:
                        return num * 0.0000254;
                    case Length.Mile:
                        return num * 0.000016;
                    case Length.Inch:
                        return num;
                    case Length.Feet:
                        return num * 0.08333;
                    case Length.Yard:
                        return num * 0.027778;
                    default:
                        return 0;
                }

            }
        }

        public static class FromFeet
        {
            public static double ConvertTo(Length unit, double num)
            {
                switch (unit)
                {
                    case Length.Millimeter:
                        return num * 304.8;
                    case Length.Centimeter:
                        return num * 30.48;
                    case Length.Meter:
                        return num * 0.3048;
                    case Length.Kilometer:
                        return num * 0.000305;
                    case Length.Mile:
                        return num * 0.00189;
                    case Length.Inch:
                        return num * 12;
                    case Length.Feet:
                        return num;
                    case Length.Yard:
                        return num * 0.33333;
                    default:
                        return 0;
                }

            }
        }

        public static class FromYard
        {
            public static double ConvertTo(Length unit, double num)
            {
                switch (unit)
                {
                    case Length.Millimeter:
                        return num * 914.4;
                    case Length.Centimeter:
                        return num * 91.44;
                    case Length.Meter:
                        return num * 0.9144;
                    case Length.Kilometer:
                        return num * 0.000914;
                    case Length.Mile:
                        return num * 0.00568;
                    case Length.Inch:
                        return num * 36;
                    case Length.Feet:
                        return num * 3;
                    case Length.Yard:
                        return num;
                    default:
                        return 0;
                }

            }
        }
    }

}
