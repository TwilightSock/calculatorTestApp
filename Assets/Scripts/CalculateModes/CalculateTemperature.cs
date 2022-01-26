using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnitsNet;
using UnitsNet.Units;
using System;

public class CalculateTemperature : MonoBehaviour,ICalculator
{
    [SerializeField]
    private OutputController outputController;
    [SerializeField]
    private TMP_Dropdown inputDropdown;
    [SerializeField]
    private TMP_Dropdown outputDropdown;

    public void Calculate()
    {
        try
        {
            string inputValue;
            switch (inputDropdown.value)
            {
                case 0:
                    inputValue = Temperature.GetAbbreviation(TemperatureUnit.DegreeCelsius);
                    break;
                case 1:
                    inputValue = Temperature.GetAbbreviation(TemperatureUnit.DegreeFahrenheit);
                    break;
                case 2:
                    inputValue = Temperature.GetAbbreviation(TemperatureUnit.Kelvin);
                    break;
                default:
                    inputValue = "Error";
                    break;
            }
           
            string outputValue;
            switch (outputDropdown.value)
            {
                case 0:
                    outputValue = Temperature.GetAbbreviation(TemperatureUnit.DegreeCelsius);
                    break;
                case 1:
                    outputValue = Temperature.GetAbbreviation(TemperatureUnit.DegreeFahrenheit);
                    break;
                case 2:
                    outputValue = Temperature.GetAbbreviation(TemperatureUnit.Kelvin);
                    break;
                default:
                    outputValue = "Error";
                    break;
            }

            Enum unitFrom = UnitParser.Default.Parse(inputValue, typeof(TemperatureUnit));

            Enum unitTo = UnitParser.Default.Parse(outputValue, typeof(TemperatureUnit));

            double convertedValue = UnitConverter.Convert(decimal.Parse(outputController.ReadText()), unitFrom, unitTo);
            decimal toValue = Convert.ToDecimal(convertedValue);
            string value = toValue.ToString();

            outputController.ShowResult(value);
        }
        catch (FormatException ex)
        {
            Debug.Log(ex.ToString());
            outputController.ShowResult("Syntax error");
        }
    }
}
