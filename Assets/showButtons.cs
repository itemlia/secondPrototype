using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showButtons : MonoBehaviour
{
    public GameObject emptyCanvasGO;

    public void OnMouseDown()
    {
        emptyCanvasGO.SetActive(true);
    }
}
