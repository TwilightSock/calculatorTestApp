using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;

public class Calculate : MonoBehaviour
{
    public string CalculateExpression(string expression) 
    {
        DataTable datatable = new DataTable();
        return datatable.Compute(expression,"").ToString();

    }
    
}
