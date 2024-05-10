using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class noButton : MonoBehaviour
{
    private int randomNum;
    private int bigRandomNum;

    private string playerAnswer;
    
    [SerializeField] private TMP_InputField inputField;
    
    [SerializeField] private shopManager _shopManager;

    public void OnMouseDown()
    {
        hagglePrice(_shopManager.currentSelling);
    }

    private void hagglePrice(sellProduce sellProduce)
    {
        sellProduce.textComp.text = "please enter your asking price"; //allows player to pick price
         
        playerAnswer = inputField.text;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            int numPrice;

            int.TryParse(playerAnswer, out numPrice); //turns string into int
            
            if ((numPrice + randomNum) <
                bigRandomNum) //checks that number isnt too big by checking it against their price - a random value
            {
                _shopManager.money += numPrice;
                _shopManager.moneyCounter.text = _shopManager.money.ToString();
                sellProduce.textComp.text = "accepted";
            }
            else //if number suggested is too big their plant wont be bought
            {
                sellProduce.textComp.text = "denied, i will no longer buy";
            }
        }
    }
}
