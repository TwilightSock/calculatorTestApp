using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureController : MonoBehaviour
{
    public void Start()
    {
        gameObject.SetActive(false);

    }
    public void ModeTemperatureOpen()
    {

        gameObject.SetActive(true);

    }

    public void ModeTemperatureClose()
    {
        gameObject.SetActive(false);

    }



}
