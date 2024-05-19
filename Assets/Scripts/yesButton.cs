using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class yesButton : MonoBehaviour
{
    [SerializeField] private shopManager _shopManager;

    private void Update()
    {
        _shopManager = GameObject.Find("shop manager").GetComponent<shopManager>();
    }

    public void OnMouseDown()
    {
        agreeAble(_shopManager.currentSelling);
    }

    public void agreeAble(sellProduce sellProduce)
    {
        _shopManager.money += sellProduce.price;
        sellProduce.textComp.text = "thank you";
        _shopManager.moneyCounter.text = _shopManager.money.ToString();
        sellProduce.clicked = false;
        Destroy(sellProduce.seed);
        sellProduce.gameObject.SetActive(false);
        
    }
}
