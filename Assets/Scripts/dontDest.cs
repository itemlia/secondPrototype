using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDest : MonoBehaviour
{
    private void Awake()
    {
        var dontDestCount = FindObjectsOfType<dontDest>().Length; //sttops the item manager from duplicating

        if (dontDestCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
