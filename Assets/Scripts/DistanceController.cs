using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceController : MonoBehaviour
{
    public void Start()
    {
        gameObject.SetActive(false);
    }
    public void ModeDistanceOpen()
    {
		gameObject.SetActive(true);	
	}

	public void ModeDistanceClose()
	{
		gameObject.SetActive(false);
	}

}
