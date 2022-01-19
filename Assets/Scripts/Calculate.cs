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
    [SerializeField]
    private Dropdown dropdownNum;
    [SerializeField]
    private Dropdown dropdownResult;

    public string CalculateExpression(string expression) 
    {
        DataTable datatable = new DataTable();
        return datatable.Compute(expression,"").ToString();

    }

    public string CalculateDistance(string value) 
    {
        Enum unitFrom = UnitParser.Default.Parse(dropdownNum.options[dropdownNum.value].text, typeof(LengthUnit));
        Enum unitTo = UnitParser.Default.Parse(dropdownResult.options[dropdownResult.value].text, typeof(LengthUnit));
        
        double convertedValue = UnitConverter.Convert(decimal.Parse(value), unitFrom, unitTo);
        decimal toValue = Convert.ToDecimal(convertedValue); 
        value = toValue.ToString();
        
        return value;
    }
}
