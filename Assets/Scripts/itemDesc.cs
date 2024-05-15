using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class itemDesc : MonoBehaviour
{
    [SerializeField] private string itemDescription;
    [SerializeField] private TextMeshProUGUI textComp;
    [SerializeField] private buyItem _buyItem;
    [SerializeField] private itemDesc ItemDesc;
    
    public int itemPrice;
    public string itemName;

    private void Start()
    {
        ItemDesc = this; //sets the current item
    }

    public void OnMouseDown()
    {
        textComp.text = itemDescription;
        _buyItem._itemDesc = ItemDesc; //tells the buyItem script what item is wanting to be bought

    }
}
