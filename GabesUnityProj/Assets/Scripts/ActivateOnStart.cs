using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnStart : MonoBehaviour
{
    public GameObject Activate;

    void Start()
    {
        Activate.gameObject.SetActive(true);
    }
}