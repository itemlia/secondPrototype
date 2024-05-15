using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class buyItem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI moneyText;
    [SerializeField] private shopManager _shopManager;
    
    public itemDesc _itemDesc;

    private void Update()
    {
        _shopManager = GameObject.Find("shop manager").GetComponent<shopManager>();
    }

    public void OnMouseDown()
    {
        if (_shopManager.money > _itemDesc.itemPrice) //if the players money is mroe than the price
        {
            _shopManager.money -= _itemDesc.itemPrice; //player can buy the item
            moneyText.text = "you have bought " + _itemDesc.itemName;
        }
        else
        {
            moneyText.text = "you dont have enough to buy " + _itemDesc.itemName;
        }
    }
}
