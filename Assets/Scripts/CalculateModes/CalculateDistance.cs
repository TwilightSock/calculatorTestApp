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
                    inputValue = "m";
                    break;
                case 1:
                    inputValue = "cm";
                    break;
                case 2:
                    inputValue = "mm";
                    break;
                case 3:
                    inputValue = "km";
                    break;
                case 4:
                    inputValue = "mi";
                    break;
                case 5:
                    inputValue = "in";
                    break;
                case 6:
                    inputValue = "ft";
                    break;
                case 7:
                    inputValue = "yd";
                    break;
                default:
                    inputValue = "Error";
                    break;
            }
            Length unitFrom = ConverterLib.Converter.ParceStringToUnit(inputValue);
            string outputValue;
            switch (outputDropdown.value)
            {
                case 0:
                    outputValue = "m";
                    break;
                case 1:
                    outputValue = "cm";
                    break;
                case 2:
                    outputValue = "mm";
                    break;
                case 3:
                    outputValue = "km";
                    break;
                case 4:
                    outputValue = "mi";
                    break;
                case 5:
                    outputValue = "in";
                    break;
                case 6:
                    outputValue = "ft";
                    break;
                case 7:
                    outputValue = "yd";
                    break;
                default:
                    outputValue = "Error";
                    break;
            }

            Length unitTo = ConverterLib.Converter.ParceStringToUnit(outputValue);

            double convertedValue = ConverterLib.Converter.UnitConverterLength(unitFrom,unitTo,decimal.Parse(outputController.ReadText()));
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
