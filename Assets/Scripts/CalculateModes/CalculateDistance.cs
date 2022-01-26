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
    private TMP_Dropdown input;
    [SerializeField]
    private TMP_Dropdown output;

    public void Calculate()
    {
         try
        {
            Enum unitFrom = UnitParser.Default.Parse(input.options[input.value].text, typeof(LengthUnit));

            Enum unitTo = UnitParser.Default.Parse(output.options[output.value].text, typeof(LengthUnit));

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
