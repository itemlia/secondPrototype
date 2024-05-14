using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class itemDesc : MonoBehaviour
{
    [SerializeField] private string itemDescription;
    [SerializeField] private TextMeshProUGUI textComp;

    public GameObject item;
    public int itemPrice;
    public string itemName;

    private void Start()
    {
        item = gameObject;
    }

    public void OnMouseDown()
    {
        textComp.text = itemDescription;
    }
}
