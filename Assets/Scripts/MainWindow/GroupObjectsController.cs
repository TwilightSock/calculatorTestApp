using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupObjectsController : MonoBehaviour
{

    public void Start()
    {
        gameObject.SetActive(true);

    }
    public void ModeDefaultOpen()
    {

        gameObject.SetActive(true);

    }

    public void ModeDefaultClose()
    {
        gameObject.SetActive(false);

    }


}
