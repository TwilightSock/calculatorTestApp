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
    private Calculate calculate;
    
    [SerializeField]
    private GameObject changeModeTo;
    [SerializeField]
    private GameObject changeModeFrom;
    [SerializeField]
    private ModeController modeController;
    
    public void AddValue()
    {
        
        Debug.Log("addValue");
        outputController.AddText(value);
    }

    public void FigureOutExpression()
    {
        Debug.Log("FigureOut");
        calculate.CalculateExpression();
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