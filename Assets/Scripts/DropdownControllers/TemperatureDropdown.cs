using ConverterLib;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ConverterLib;
using TMPro;

public class TemperatureDropdown : MonoBehaviour,IDropdownController<Temperature>
{
    [SerializeField]
    private TMP_Dropdown dropdown;

    public void Awake()
    {
        List<string> optionList = new List<string> { "°C", "°F", "K" };
        dropdown.AddOptions(optionList);
    }
    public Temperature GetValueFromDropdown()
    {
        switch (dropdown.value)
        {
            case 0:
                return Temperature.Celsius;
            case 1:
                return Temperature.Fahrenheit;
            case 2:
                return Temperature.Kelvin;
            default:
                return Temperature.unknown;
        }
    }
}
