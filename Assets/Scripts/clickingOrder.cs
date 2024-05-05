using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class clickingOrder : MonoBehaviour
{
    [SerializeField] private int buttonNumber;

    [SerializeField] private cutPlants _cutPlants;
    [SerializeField] private int index;
    
    public void OnMouseDown()
    {
        if (_cutPlants.buttonOrder[_cutPlants.clickedOrder.Count] == buttonNumber) //checks individual list values when clicked
        {
            _cutPlants.clickedOrder.Add(buttonNumber); //if value is right then added to list and button is turnt green
            ColorBlock myColor = gameObject.GetComponent<Button>().colors;

            myColor.normalColor = Color.green;

            gameObject.GetComponent<Button>().colors = myColor;
            _cutPlants.matchNum++; //match number increases to show a match has been made
        }

    }
}
