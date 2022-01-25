using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
    private string value;
    [SerializeField]
    private OutputController outputController;
    [SerializeField]
    private DistanceController distanceController;
    [SerializeField]
    private GroupObjectsController groupObjectsController;
    [SerializeField]
    private TemperatureController temperatureController;
    public void AddValue()
    {
        
        Debug.Log("addValue");
        outputController.AddText(value);
    }

    public void FigureOutExpression()
    {
        Debug.Log("FigureOut");
        outputController.ShowResult();
    }

    public void Clear()
    {
        Debug.Log("Clear");
        outputController.ClearPanel();
    }

    public void DistanceOpen() 
    {
        distanceController.ModeDistanceOpen();
    }

    public void TemperatureOpen()
    {
        temperatureController.ModeTemperatureOpen();
    }

    public void DefaultClose() 
    {
        groupObjectsController.ModeDefaultClose();
    }


}  