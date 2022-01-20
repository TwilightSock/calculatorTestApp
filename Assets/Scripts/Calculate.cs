using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System;
using UnityEngine.UI;
using UnitsNet;
using UnitsNet.Units;

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

    public string CalculateDistance(string value,Dropdown dropdownNum,Dropdown dropdownResult)
    {
        try
        {
            Enum unitFrom = UnitParser.Default.Parse(dropdownNum.options[dropdownNum.value].text, typeof(LengthUnit));     /*UnitParser converts names like "cm,mm,km ..." to enum like "Length.Centimeter,Length.Kilometer ..." 
                                                                                                                                     */
            Enum unitTo = UnitParser.Default.Parse(dropdownResult.options[dropdownResult.value].text, typeof(LengthUnit));

            double convertedValue = UnitConverter.Convert(decimal.Parse(value), unitFrom, unitTo);
            decimal toValue = Convert.ToDecimal(convertedValue);
            value = toValue.ToString();

            return value;
        }
        catch (UnitNotFoundException ex)
        {
            Debug.Log(ex.ToString());
            return "Syntax Error"; 
        }
    }

    public string CalculateTemperature(string value,Dropdown dropdownNum,Dropdown dropdownResult)
    {
        try
        {
            Enum unitFrom = UnitParser.Default.Parse("mm", typeof(TemperatureUnit));
            
            Enum unitTo = UnitParser.Default.Parse(dropdownResult.options[dropdownResult.value].text, typeof(TemperatureUnit));

            double convertedValue = UnitConverter.Convert(decimal.Parse(value), unitFrom, unitTo);
            decimal toValue = Convert.ToDecimal(convertedValue);
            value = toValue.ToString();

            return value;
        }
        catch(UnitNotFoundException ex) 
        {
            Debug.Log(ex.ToString());
            return "Syntax Error";
        }
        
    }
}
