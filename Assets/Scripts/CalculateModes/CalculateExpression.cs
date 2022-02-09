using ConverterLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;


public class CalculateExpression : MonoBehaviour,ICalculator
{
    
    public string Calculate(object abstractContainer)
    {
        Container<Length,Temperature> container = (Container<Length,Temperature>) abstractContainer;
        string expression = container.Expression;
        
        string pattern = @"^[-+]?(\d+\.?\d*){1}([-,+,*,/]){1}(\d+\.?\d*){1}";
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
                        expression = valueResult.ToString();
                        break;
                    case "-":
                        valueResult= value1 - value2;
                        expression = valueResult.ToString();
                        break;
                    case "*":
                        valueResult = value1 * value2;
                        expression = valueResult.ToString();
                        break;
                    case "/":
                        valueResult = value1 / value2;
                        expression = valueResult.ToString();
                        break;
                    default:
                        throw new Exception("Syntax Error");
                        expression="";
                }

            }
        return expression;

    }

}
