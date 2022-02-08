using ConverterLib;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ConverterLib;
using TMPro;

public class TemperatureDropdown : MonoBehaviour,IDropdownController
{
    [SerializeField]
    private TMP_Dropdown dropdown;

    public void Awake()
    {
        List<string> optionList = new List<string> { "°C", "°F", "K" };
        dropdown.AddOptions(optionList);
    }
    public int GetValueFromDropdown()
    {
        switch (dropdown.value)
        {
            case 0:
                return 0;
            case 1:
                return 1;
            case 2:
                return 2;
            default:
                return 3;
        }
    }
}
