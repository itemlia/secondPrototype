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

    public sellProduce _sellProduce1;
    public sellProduce _sellProduce2;
    public sellProduce _sellProduce3;

    private bool condition;
    private bool isRunning;
    private int randomNum;
    private int bigRandomNum;
    
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TextMeshProUGUI moneyCounter;

    [SerializeField] private string playerAnswer;
    [SerializeField] private int money;
    
    [SerializeField] private Button sellOne;
    [SerializeField] private Button sellTwo;
    [SerializeField] private Button sellThree;

    private void Start()
    {
        randomNum = Random.Range(0, 6); //generates random number
        bigRandomNum = Random.Range(15, 20);
        Debug.Log(randomNum);
        Debug.Log(bigRandomNum);
    }

   
    public void getSeed() //checks which seed is being sold
    {
        if (_sellProduce1.clicked)
        {
            StartCoroutine(setPrice(_sellProduce1));
        }
        else if (_sellProduce2.clicked)
        {
            StartCoroutine(setPrice(_sellProduce2));
        } 
        else if (_sellProduce3.clicked)
        {
            StartCoroutine(setPrice(_sellProduce3));
        }
    }
    public IEnumerator setPrice(sellProduce sellProduce) 
    {
        playerAnswer = inputField.text;

        yield return new WaitForSeconds(3);
        
            if (playerAnswer == "yes") //if player agrees with price sell seed and give them the money
            {
                isRunning = false;
                money += sellProduce.price;
                sellProduce.textComp.text = "thank you";
                moneyCounter.text = money.ToString();
                yield return new WaitForSeconds(3);isRunning = true;
                sellProduce.textComp.text = "";
                inputField.Select();
                inputField.text = "";
                sellProduce.backgroundImage.SetActive(false);
                gameObject.SetActive(false);
            }
            else if (playerAnswer == "no") //if they dont agree then they can 'haggle'
            {
                StartCoroutine(hagglePrice(sellProduce));
            }
            else
            {
                sellProduce.textComp.text = "error, please retype answer";
                StartCoroutine(setPrice(sellProduce));
            }
        
    }

    IEnumerator hagglePrice(sellProduce sellProduce)
    {
        sellProduce.textComp.text = "please enter your asking price"; //allows player to pick price
        yield return new WaitForSeconds(7);
        int numPrice; 
        
        int.TryParse(playerAnswer, out numPrice); //turns string into int
            
        if ((numPrice + randomNum) < bigRandomNum) //checks that number isnt too big by checking it against their price - a random value
        {
            money += numPrice;
            moneyCounter.text = money.ToString();
            sellProduce.textComp.text = "accepted";
            yield return new WaitForSeconds(3);
            sellProduce.textComp.text = "";
            inputField.Select();
            inputField.text = "";
            sellProduce.backgroundImage.SetActive(false);
            gameObject.SetActive(false);
        }
        else //if number suggested is too big their plant wont be bought
        {
            sellProduce.textComp.text = "denied, i will no longer buy";
            yield return new WaitForSeconds(3);
            sellProduce.textComp.text = "";
            //inputField.Select();
            //inputField.text = "";
            sellProduce.backgroundImage.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}



