using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TemperatureButtonConrtroller : MonoBehaviour
{
    [SerializeField]
    private string value;
    [SerializeField]
    private OutputController outputController;
    [SerializeField]
    private TMP_Dropdown input;
    [SerializeField]
    private TMP_Dropdown output;
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

    public void ChangeModeButton()
    {
        modeController.ModeOpen(changeModeFrom, changeModeTo);
    }

}
