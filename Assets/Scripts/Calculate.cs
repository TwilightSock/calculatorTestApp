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
        int dropdownValue;
        int dropdownValueResult;
       

        Enum unit = UnitParser.Default.Parse(dropdownNum.options[dropdownNum.value].text, typeof(LengthUnit));
        Debug.Log(unit.ToString());
       
        return "";
    }
}
