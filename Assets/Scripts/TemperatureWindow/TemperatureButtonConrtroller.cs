using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TemperatureButtonConrtroller : MonoBehaviour
{
    public string value;
    [SerializeField]
    private OutputController outputController;
    [SerializeField]
    private GroupObjectsController groupObjectsController;
    [SerializeField]
    private TemperatureController temperatureController;
    [SerializeField]
    private Dropdown input;
    [SerializeField]
    private Dropdown output;
    public void AddValue()
    {

        Debug.Log("addValue");
        outputController.AddText(value);
    }

    public void ConvertTemperature()
    {
        Debug.Log("Convert");
        outputController.ShowConvertedTemperature(input,output);
    }

    public void Clear()
    {
        Debug.Log("Clear");
        outputController.ClearPanel();
    }


    public void TemperatureClose()
    {
        temperatureController.ModeTemperatureClose();
    }

    public void DefaultOpen()
    {
        groupObjectsController.ModeDefaultOpen();
    }
}
