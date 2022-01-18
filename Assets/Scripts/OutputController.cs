using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutputController : MonoBehaviour
{
    private Text displayText;
    [SerializeField]
    private Calculate calculate;
    [SerializeField]
    private OutputController outputText;

    void Awake()
    {
        displayText = (Text)outputText.gameObject.GetComponent<Text>();
    }

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
}