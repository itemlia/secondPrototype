using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class showMoney : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI money;
    private shopManager _shopManager;

    private void Start()
    {
        _shopManager = GameObject.Find("shop manager").GetComponent<shopManager>();
    }

    private void Update()
    {
        money.text = _shopManager.money.ToString();
    }
}
