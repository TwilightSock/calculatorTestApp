using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using ConverterLib;
using System;


public class CalculateTemperature : MonoBehaviour,ICalculator
{
    [SerializeField]
    private Temperature _unitFrom;
    [SerializeField]
    private Temperature _unitTo;

    public Temperature unitTo
    {
        get { return _unitTo; }
        set { _unitTo = value; }
    }

    public Temperature unitFrom
    {
        get { return _unitFrom; }
        set { _unitFrom = value; }
    }

    public string Calculate(object abstractContainer)
    {
        Container<Length, Temperature> container = (Container<Length, Temperature>)abstractContainer;
        unitFrom = container.temperatureUnitFrom;
        unitTo = container.temperatureUnitTo;
        string expression = container.Expression;
        double convertedValue = ConverterLib.Converter.UnitConverterTemperature(unitFrom, unitTo, decimal.Parse(expression));
        decimal toValue = Convert.ToDecimal(convertedValue);
        return  toValue.ToString();
       
    }
}
