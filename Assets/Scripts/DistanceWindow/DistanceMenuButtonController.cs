using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceMenuButtonController : MonoBehaviour
{
    public string value;
    [SerializeField]
    private OutputController outputController;
    [SerializeField]
    private DistanceController distanceController;
    [SerializeField]
    private GroupObjectsController groupObjectsController;
    [SerializeField]
    private Dropdown dropdownNum;
    [SerializeField]
    private Dropdown dropdownResult;
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
