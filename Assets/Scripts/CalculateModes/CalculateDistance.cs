using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using ConverterLib;
using System;

public class CalculateDistance : MonoBehaviour,ICalculator
{
    [SerializeField]
    private OutputController outputController;
    [SerializeField]
    private DistanceDropdown inputDropdown;
    [SerializeField]
    private DistanceDropdown outputDropdown;

    public void Calculate() 
    {
        try
        {
            Length unitFrom = (Length)inputDropdown.GetValueFromDropdown();
            Length unitTo = (Length)outputDropdown.GetValueFromDropdown();

            double convertedValue = ConverterLib.Converter.UnitConverterLength(unitFrom, unitTo, decimal.Parse(outputController.ReadText()));
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
