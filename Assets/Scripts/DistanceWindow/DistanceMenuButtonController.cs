using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DistanceMenuButtonController : MonoBehaviour
{
    [SerializeField]
    private string value;
   
    [SerializeField]
    private OutputController outputController;
    [SerializeField]
    private Calculate calculate;
   
    [SerializeField]
    private TMP_Dropdown dropdownNum;
    [SerializeField]
    private TMP_Dropdown dropdownResult;
   
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

    public void ConvertDistance()
    {
        Debug.Log("Convert");
        calculate.CalculateDistance(dropdownNum,dropdownResult);
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
