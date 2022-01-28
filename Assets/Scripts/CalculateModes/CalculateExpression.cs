using System;
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
            string expression = outputController.ReadText();
            string pattern = @"^[-+]?(\d+\.?\d*)+([-|+|*|/]{1})+(\d+\.?\d*)";
            System.Text.RegularExpressions.MatchCollection matchCollection = System.Text.RegularExpressions.Regex.Matches(expression, pattern);
            int check = matchCollection.Count;
            if (check == 0)
            {
                throw new Exception("Syntax Error");
            }
            foreach (System.Text.RegularExpressions.Match m in
                System.Text.RegularExpressions.Regex.Matches(expression, pattern))
            {
                decimal value1 = Decimal.Parse(m.Groups[1].Value);
                decimal value2 = Decimal.Parse(m.Groups[3].Value);
                decimal valueResult;
                switch (m.Groups[2].Value)
                {
                    case "+":
                        valueResult = value1 + value2;
                        Debug.Log(valueResult);
                        outputController.ShowResult(valueResult.ToString());
                        break;
                    case "-":
                        valueResult= value1 - value2;
                        outputController.ShowResult(valueResult.ToString());
                        break;
                    case "*":
                        valueResult = value1 * value2;
                        outputController.ShowResult(valueResult.ToString());
                        break;
                    case "/":
                        valueResult = value1 / value2;
                        outputController.ShowResult(valueResult.ToString());
                        break;
                }
            }
   
        }
        catch (Exception ex)
        {
            Debug.Log(ex);
            outputController.ShowResult("Syntax error");
        }


    }

}
