using ConverterLib;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DistanceDropdown : MonoBehaviour,IDropdownController<Length>
{
    [SerializeField]
    private TMP_Dropdown dropdown;

    public void Awake()
    {
        List<string> optionList = new List<string> { "m", "cm", "mm", "km", "mi", "In", "ft", "yd" };
        dropdown.AddOptions(optionList);
    }
    
    public Length GetValueFromDropdown()
    {
        switch (dropdown.value)
        {
            case 0:
                return Length.Meter;
            case 1:
                return Length.Centimeter;
            case 2:
                return Length.Millimeter;
            case 3:
                return Length.Kilometer;
            case 4:
                return Length.Mile;
            case 5:
                return Length.Inch;
            case 6:
                return Length.Feet;
            case 7:
                return Length.Yard;
            default:
                return Length.unknown;
        }
    }

    
}
