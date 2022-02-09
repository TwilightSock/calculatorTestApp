using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using ConverterLib;
using System;


public class CalculateDistance : MonoBehaviour,ICalculator
{
    [SerializeField]
    private Length _unitFrom;
    [SerializeField]
    private Length _unitTo;

    public Length UnitTo 
    {
        get { return _unitTo; }
        set { _unitTo = value; } 
    }

    public Length UnitFrom
    {
        get { return _unitFrom; }
        set { _unitFrom = value; }
    }
    public string Calculate(object abstractContainer) 
    {
        Container<Length, Temperature> container = (Container<Length, Temperature>)abstractContainer;
        UnitFrom = container.distanceUnitFrom;
        UnitTo = container.distanceUnitTo;
        string expression = container.Expression;
        double convertedValue = ConverterLib.Converter.UnitConverterLength(UnitFrom, UnitTo, decimal.Parse(expression));
        decimal toValue = Convert.ToDecimal(convertedValue);
        return toValue.ToString();
    }
  
}
