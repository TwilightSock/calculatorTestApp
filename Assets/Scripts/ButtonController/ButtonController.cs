using ConverterLib;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public struct Container<T,U>
{
    private string _expression;
    private T _distanceUnitTo;
    private T _distanceUnitFrom;
    private U _temperatureUnitTo;
    private U _temperatureUnitFrom;

    public T distanceUnitFrom { get { return _distanceUnitFrom; } set { _distanceUnitFrom = value; } }
    public T distanceUnitTo { get { return _distanceUnitTo; } set { _distanceUnitTo = value; } }

    public U temperatureUnitFrom { get { return _temperatureUnitFrom; } set { _temperatureUnitFrom = value; } }
    public U temperatureUnitTo { get { return _temperatureUnitTo; } set { _temperatureUnitTo = value; } }
    public string Expression { get { return _expression; } set { _expression = value; } }

} 


public class ButtonController : MonoBehaviour
{
    [SerializeField]
    private string value;

    private Container<Length,Temperature> container;
   
    [SerializeField]
    private OutputController outputController;

    [SerializeField]
    private GameObject interfaceGameObject;
    private ICalculator calculate;
    
    [SerializeField]
    private GameObject changeModeTo;
    [SerializeField]
    private GameObject changeModeFrom;
    [SerializeField]
    private ModeController modeController;


    public void Start()
    {

        if (changeModeFrom.Equals(GameObject.Find("DefaultGroupObjects")))
        {
            calculate = interfaceGameObject.GetComponent<CalculateExpression>();
        }
        if (changeModeFrom.Equals(GameObject.Find("DistanceGroupObjects"))) 
        {
            calculate = interfaceGameObject.GetComponent<CalculateDistance>();
        }
        if (changeModeFrom.Equals(GameObject.Find("TemperatureGroupObjects"))) 
        {
            calculate = interfaceGameObject.GetComponent<CalculateTemperature>();
        }
    }
    public void AddValue()
    {
        
        Debug.Log("addValue");
        outputController.AddText(value);
    }

    public void Evaluate()
    {
        try
        {
            if (changeModeFrom.Equals(GameObject.Find("DistanceGroupObjects")))
            {               
                IDropdownController<Length> dropdownController = GameObject.Find("DistanceInputDropdown").GetComponent<DistanceDropdown>();
                container.distanceUnitFrom = dropdownController.GetValueFromDropdown();
                dropdownController = GameObject.Find("DistanceOutputDropdown").GetComponent<DistanceDropdown>();
                container.distanceUnitTo = dropdownController.GetValueFromDropdown();

            }
            if (changeModeFrom.Equals(GameObject.Find("TemperatureGroupObjects")))
            {               
                IDropdownController<Temperature> dropdownController = GameObject.Find("TemperatureInputDropdown").GetComponent<TemperatureDropdown>();
                container.temperatureUnitFrom = dropdownController.GetValueFromDropdown();
                dropdownController = GameObject.Find("TemperatureOutputDropdown").GetComponent<TemperatureDropdown>();
                container.temperatureUnitTo = dropdownController.GetValueFromDropdown();
            }

            Debug.Log("FigureOut");
            container.Expression = outputController.ReadText();
            string result = calculate.Calculate(container);
            outputController.ShowResult(result);
        }
        catch (Exception ex) 
        {
            outputController.ShowResult("Error");
        }
    }

    public void Clear()
    {
        Debug.Log("Clear");
        outputController.ClearPanel();
    }

    public void ChangeModeButton() 
    {
        modeController.ModeOpen(changeModeFrom, changeModeTo);
    }

}  