using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class inputPrice : MonoBehaviour
{
    public static inputPrice price;

    public sellProduce _sellProduce;

    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TextMeshProUGUI moneyCounter;

    [SerializeField] private string playerAnswer;
    [SerializeField] private int money;
    [SerializeField] private int randomNum;

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

    private void Start()
    {
        randomNum = Random.Range(0, 6);
    }

    public void setPrice()
    {
        playerAnswer = inputField.text;
        
        if (playerAnswer == "yes")
        {
            money += _sellProduce.price;
            _sellProduce.textComp.text = "thank you";
            moneyCounter.text = money.ToString();
        }
        else if (playerAnswer == "no")
        {
           StartCoroutine(hagglePrice());
        }
        else
        {
            _sellProduce.textComp.text = "error, please retype answer";
        }

    }

    IEnumerator hagglePrice()
    {
        _sellProduce.textComp.text = "please enter your asking price";
        inputField.Select();
        inputField.text = "";
        yield return new WaitForSeconds(5);
        int numPrice = int.Parse(playerAnswer);
            
        if (numPrice <= numPrice - randomNum)
        {
            _sellProduce.textComp.text = "accepted";
            money += numPrice;
            moneyCounter.text = money.ToString();
            _sellProduce.textComp.text = "";
        }
        else
        {
            _sellProduce.textComp.text = "denied, i will no longer buy";
        }
    }
}



