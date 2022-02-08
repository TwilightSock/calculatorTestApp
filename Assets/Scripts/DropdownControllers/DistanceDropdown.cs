using ConverterLib;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DistanceDropdown : MonoBehaviour,IDropdownController
{
    [SerializeField]
    private TMP_Dropdown dropdown;

    public void Awake()
    {
        List<string> optionList = new List<string> { "m", "cm", "mm", "km", "mi", "In", "ft", "yd" };
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
            case 3:
                return 3;
            case 4:
                return 4;
            case 5:
                return 5;
            case 6:
                return 6;
            case 7:
                return 7;
            default:
                return 8;
        }
    }

    
}
