using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class CalculateExpression : MonoBehaviour,ICalculator
{
    [SerializeField]
    private OutputController outputController;

    public void Calculate()
    {
        try
        {
            DataTable datatable = new DataTable();
            outputController.ShowResult(datatable.Compute(outputController.ReadText(), "").ToString());
        }
        catch (SyntaxErrorException ex)
        {
            Debug.Log(ex);
            outputController.ShowResult("Syntax error");
        }


    }

}
