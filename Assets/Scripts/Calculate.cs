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
    

    public string CalculateExpression(string expression) 
    {
        try
        {
            DataTable datatable = new DataTable();
            return datatable.Compute(expression, "").ToString();
        }
        catch(SyntaxErrorException ex) 
        {
            Debug.Log(ex);
            return "Syntax error";
        }
       

    }

    public string CalculateDistance(string value,TMP_Dropdown dropdownNum,TMP_Dropdown dropdownResult)
    {
        try
        {
            Enum unitFrom = UnitParser.Default.Parse(dropdownNum.options[dropdownNum.value].text, typeof(LengthUnit));
                                                                                                                                  
            Enum unitTo = UnitParser.Default.Parse(dropdownResult.options[dropdownResult.value].text, typeof(LengthUnit));

            double convertedValue = UnitConverter.Convert(decimal.Parse(value), unitFrom, unitTo);
            decimal toValue = Convert.ToDecimal(convertedValue);
            value = toValue.ToString();

            return value;
        }
        catch (FormatException ex)
        {
            Debug.Log(ex.ToString());
            return "Syntax Error"; 
        }
    }

    public string CalculateTemperature(string value,TMP_Dropdown dropdownNum,TMP_Dropdown dropdownResult)
    {
        try
        {
            Enum unitFrom = UnitParser.Default.Parse(dropdownNum.options[dropdownNum.value].text, typeof(TemperatureUnit));
            
            Enum unitTo = UnitParser.Default.Parse(dropdownResult.options[dropdownResult.value].text, typeof(TemperatureUnit));

            double convertedValue = UnitConverter.Convert(decimal.Parse(value), unitFrom, unitTo);
            decimal toValue = Convert.ToDecimal(convertedValue);
            value = toValue.ToString();

            return value;
        }
        catch(FormatException ex) 
        {
            Debug.Log(ex.ToString());
            return "Syntax Error";
        }
        
    }
}
