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
    private DistanceController distanceController;
    [SerializeField]
    private GroupObjectsController groupObjectsController;
    [SerializeField]
    private TMP_Dropdown dropdownNum;
    [SerializeField]
    private TMP_Dropdown dropdownResult;
    public void AddValue()
    {

        Debug.Log("addValue");
        outputController.AddText(value);
    }

    public void ConvertDistance()
    {
        Debug.Log("Convert");
        outputController.ShowConvertedDistance(dropdownNum,dropdownResult);
    }

    public void Clear()
    {
        Debug.Log("Clear");
        outputController.ClearPanel();
    }

   
    public void DistanceClose()
    {
        distanceController.ModeDistanceClose();
    }

    public void DefaultOpen() 
    {
        groupObjectsController.ModeDefaultOpen();
    }
}
