using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class inputPrice : MonoBehaviour
{
    public static inputPrice price;

    public sellProduce _sellProduce1;
    public sellProduce _sellProduce2;
    public sellProduce _sellProduce3;

    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TextMeshProUGUI moneyCounter;

    [SerializeField] private string playerAnswer;
    [SerializeField] private int money;
    [SerializeField] private int randomNum;
    
    [SerializeField] private Button sellOne;
    [SerializeField] private Button sellTwo;
    [SerializeField] private Button sellThree;

    private void Start()
    {
        randomNum = Random.Range(0, 6);
        //getSeed();
    }

   
    public void getSeed()
    {
        if (_sellProduce1.clicked)
        {
            setPrice(_sellProduce1);
        }
        else if (_sellProduce2.clicked)
        {
            setPrice(_sellProduce2);
        } 
        else if (_sellProduce3.clicked)
        {
            setPrice(_sellProduce3);
        }
    }
    
    private void setPrice(sellProduce sellProduce)
    {
        playerAnswer = inputField.text;
        
        if (playerAnswer == "yes")
        {
            money += sellProduce.price;
            sellProduce.textComp.text = "thank you";
            moneyCounter.text = money.ToString();
            sellProduce.textComp.text = "";
            inputField.Select();
            inputField.text = "";
            sellProduce.backgroundImage.SetActive(false);
            gameObject.SetActive(false);
        }
        else if (playerAnswer == "no")
        {
           StartCoroutine(hagglePrice(sellProduce));
        }
        else
        {
            sellProduce.textComp.text = "error, please retype answer";
        }

    }

    IEnumerator hagglePrice(sellProduce sellProduce)
    {
        sellProduce.textComp.text = "please enter your asking price";
        inputField.Select();
        inputField.text = "";
        yield return new WaitForSeconds(5);
        int numPrice = int.Parse(playerAnswer);
            
        if (numPrice <= numPrice - randomNum)
        {
            sellProduce.textComp.text = "accepted";
            money += numPrice;
            moneyCounter.text = money.ToString();
            sellProduce.textComp.text = "";
            inputField.Select();
            inputField.text = "";
            sellProduce.backgroundImage.SetActive(false);
            gameObject.SetActive(false);
        }
        else
        {
            sellProduce.textComp.text = "denied, i will no longer buy";
            sellProduce.textComp.text = "";
            inputField.Select();
            inputField.text = "";
            sellProduce.backgroundImage.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}



