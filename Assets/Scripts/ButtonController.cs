using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public string value;
    [SerializeField]
    private OutputController outputController;
    [SerializeField]
    private DistanceController distanceController;

   


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

    public void DistanceClose() 
    {
        distanceController.ModeDistanceClose();
    }
}  