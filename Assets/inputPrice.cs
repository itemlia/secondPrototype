using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class inputPrice : MonoBehaviour
{
    public static inputPrice price;

    public sellProduce _sellProduce;
    
    [SerializeField] private TMP_InputField inputField;
    
    [SerializeField] private string playerAnswer;
    [SerializeField] private int money;

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
        playerAnswer = inputField.text;

        if (playerAnswer == "yes")
        {
            money = _sellProduce.price;
            _sellProduce.textComp.text = "thank you";
        }
        else if (playerAnswer == "no")
        {
            _sellProduce.textComp.text = "please enter your asking price";
        }
        else
        {
            _sellProduce.textComp.text = "error, please retype answer";
        }
        
    }
}
