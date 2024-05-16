using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class buyItem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI moneyText;
    [SerializeField] private shopManager _shopManager;
    [SerializeField] private itemArray _itemArray;
    
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
            
            _itemArray.boughtItems.Add(_itemDesc
                .itemPrefab); //adds the prefab of the item into the list so it can be instatntiated into the level
        }
        else
        {
            moneyText.text = "you dont have enough to buy " + _itemDesc.itemName;
        }
    }
}
