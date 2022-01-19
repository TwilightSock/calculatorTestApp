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
    public void AddValue()
    {

        Debug.Log("addValue");
        outputController.AddText(value);
    }

    public void ConvertDistance()
    {
        Debug.Log("Convert");
        outputController.ShowConvertedDistance();
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
