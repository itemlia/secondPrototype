using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class yesButton : MonoBehaviour
{
    public sellProduce _sellProduce1;
    public sellProduce _sellProduce2;
    public sellProduce _sellProduce3;
    
    private int randomNum;
    private int bigRandomNum;

    [SerializeField] private TextMeshProUGUI moneyCounter;
    [SerializeField] private int money;

    private sellProduce currentSelling;

    public void Update() //checks which seed is being sold
    {
        if (_sellProduce1.clicked)
        {
            currentSelling = _sellProduce1;
        }
        else if (_sellProduce2.clicked)
        {
            currentSelling = _sellProduce2;
        }
        else if (_sellProduce3.clicked)
        {
            currentSelling = _sellProduce3;
        }
    }

    public void OnMouseDown()
    {
        agreeAble(currentSelling);
    }

    public void agreeAble(sellProduce sellProduce)
    {
        money += sellProduce.price;
        sellProduce.textComp.text = "thank you";
        moneyCounter.text = money.ToString();
    }
}
