using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System;
using UnityEngine.UI;
using UnitsNet;
using UnitsNet.Units;
using TMPro;

public class Calculate : MonoBehaviour
{
    [SerializeField]
    private OutputController outputController;

    public void CalculateExpression() 
    {
        try
        {
            DataTable datatable = new DataTable();
            outputController.ShowResult(datatable.Compute(outputController.ReadText(), "").ToString());
        }
        catch(SyntaxErrorException ex) 
        {
            Debug.Log(ex);
            outputController.ShowResult("Syntax error");
        }
       

    }

    public void CalculateDistance(TMP_Dropdown dropdownNum,TMP_Dropdown dropdownResult)
    {
        try
        {
            Enum unitFrom = UnitParser.Default.Parse(dropdownNum.options[dropdownNum.value].text, typeof(LengthUnit));
                                                                                                                                  
            Enum unitTo = UnitParser.Default.Parse(dropdownResult.options[dropdownResult.value].text, typeof(LengthUnit));

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

    public void CalculateTemperature(TMP_Dropdown dropdownNum,TMP_Dropdown dropdownResult)
    {
        try
        {
            Enum unitFrom = UnitParser.Default.Parse(dropdownNum.options[dropdownNum.value].text, typeof(TemperatureUnit));
            
            Enum unitTo = UnitParser.Default.Parse(dropdownResult.options[dropdownResult.value].text, typeof(TemperatureUnit));

            double convertedValue = UnitConverter.Convert(decimal.Parse(outputController.ReadText()), unitFrom, unitTo);
            decimal toValue = Convert.ToDecimal(convertedValue);
            string value = toValue.ToString();

            outputController.ShowResult(value);
        }
        catch(FormatException ex) 
        {
            Debug.Log(ex.ToString());
            outputController.ShowResult("Syntax error");
        }
        
    }
}
