using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OutputController : MonoBehaviour
{
    
   
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

    public string ReadText() 
    {
        string str = displayText.text;
        return str;
    }

    public void ShowResult(string answer) 
    {
        displayText.text = answer;
    }
}