using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OutputController : MonoBehaviour
{
    
    [SerializeField]
    private Calculate calculate;
    [SerializeField]
    private TMP_Text displayText;

    

    public void ClearPanel()
    {
        displayText.text = "";
    }

    public void AddText(string newText)
    {
        displayText.text += newText;
    }

    public void ShowResult()
    {
        string answer = calculate.CalculateExpression(displayText.text);
        displayText.text = answer;
    }

    public void ShowConvertedDistance(TMP_Dropdown inputDropdown,TMP_Dropdown outputDropdown) 
    {
        string answer = calculate.CalculateDistance(displayText.text,inputDropdown,outputDropdown);
        displayText.text = answer;
    }

    public void ShowConvertedTemperature(TMP_Dropdown inputDropdown,TMP_Dropdown outputDropdown)
    {
        string answer = calculate.CalculateTemperature(displayText.text, inputDropdown, outputDropdown);
        displayText.text = answer;
    }
}