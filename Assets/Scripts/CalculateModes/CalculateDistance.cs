using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnitsNet;
using UnitsNet.Units;
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
                    inputValue = "In";
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
            Enum unitFrom = UnitParser.Default.Parse(inputValue, typeof(LengthUnit));
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
                    outputValue = "In";
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

            Enum unitTo = UnitParser.Default.Parse(outputValue, typeof(LengthUnit));

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
