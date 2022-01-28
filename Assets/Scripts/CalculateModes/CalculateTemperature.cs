using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using ConverterLib;
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
                    inputValue = "Celsius";
                    break;
                case 1:
                    inputValue = "Fahrenheit";
                    break;
                case 2:
                    inputValue = "Kelvin";
                    break;
                default:
                    inputValue = "Error";
                    break;
            }
           
            string outputValue;
            switch (outputDropdown.value)
            {
                case 0:
                    outputValue = "Celsius";
                    break;
                case 1:
                    outputValue = "Fahrenheit";
                    break;
                case 2:
                    outputValue = "Kelvin";
                    break;
                default:
                    outputValue = "Error";
                    break;
            }

            Temperature unitFrom = ConverterLib.Converter.ParceStringToUnitTemperature(inputValue);
            Temperature unitTo=ConverterLib.Converter.ParceStringToUnitTemperature(outputValue);

            double convertedValue = ConverterLib.Converter.UnitConverterTemperature(unitFrom, unitTo, decimal.Parse(outputController.ReadText()));
            decimal toValue = Convert.ToDecimal(convertedValue);
            string value = toValue.ToString();

            outputController.ShowResult(value);
        }
        catch (System.Exception e)
        {
            if (e is FormatException)
            {
                Debug.Log(e.ToString());
                outputController.ShowResult("Syntax error");
            }
            if (e is System.Exception)
            {
                outputController.ShowResult(e.Message);
            }
        }
    }
}
