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
    private TemperatureDropdown inputDropdown;
    [SerializeField]
    private TemperatureDropdown outputDropdown;

    public void Calculate()
    {
        try
        {
            Temperature unitFrom = inputDropdown.GetValueFromDropdown();
            Temperature unitTo =  outputDropdown.GetValueFromDropdown();

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
