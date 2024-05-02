using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class inputPrice : MonoBehaviour
{
    public static inputPrice price;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private string playerPrice;

    private void Awake()
    {
        if (price == null)
        {
            price = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void setPrice()
    {
        playerPrice = inputField.text;
    }
}
