using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class shopManager : MonoBehaviour
{
    public sellProduce _sellProduce1;
    public sellProduce _sellProduce2;
    public sellProduce _sellProduce3;
    
    public TextMeshProUGUI moneyCounter;
    public int money;

    public sellProduce currentSelling;

    private void Awake()
    {
        var shopManCount = FindObjectsOfType<shopManager>().Length; //sttops the shop manager from duplicating

        if (shopManCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

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
}
