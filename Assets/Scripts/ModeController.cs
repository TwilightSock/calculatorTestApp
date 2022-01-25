using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] gameObjects;

    public void Awake()
    {
        foreach(GameObject gameObject in gameObjects) 
        {
            gameObject.SetActive(false);
        }
    }
    public void ModeOpen(GameObject changeModeFrom, GameObject changeModeTo)
    {
       changeModeTo.SetActive(!changeModeTo.activeSelf);
       changeModeFrom.SetActive(!changeModeFrom.activeSelf);
    }

}
