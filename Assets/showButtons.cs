using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showButtons : MonoBehaviour
{
    [SerializeField]private GameObject emptyCanvasGO;

    public void OnMouseDown()
    {
        emptyCanvasGO.SetActive(true);
    }
}
