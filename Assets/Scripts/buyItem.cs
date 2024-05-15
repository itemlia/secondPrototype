using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class buyItem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI moneyText;

    [SerializeField] private itemDesc _itemDesc;
    [SerializeField] private shopManager _shopManager;

    public void OnMouseDown()
    {
        if (_shopManager.money > _itemDesc.itemPrice)
        {
            _shopManager.money -= _itemDesc.itemPrice;
            moneyText.text = "you have bought " + _itemDesc.itemName;
        }
        else
        {
            moneyText.text = "you dont have enough to buy " + _itemDesc.itemName;
        }
    }
}
