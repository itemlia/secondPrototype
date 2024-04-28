using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showButtons : MonoBehaviour
{
    [SerializeField] private GameObject emptyCanvasGO;

    [SerializeField] private Button click;

    public void Start()
    {
        var btn = click.GetComponent<Button>();
        btn.onClick.AddListener(buttonsActive);
    }

    public void buttonsActive()
    {
        emptyCanvasGO.SetActive(true);
    }
}
