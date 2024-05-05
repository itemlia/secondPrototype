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
        if (_cutPlants.buttonOrder[_cutPlants.clickedOrder.Count] == buttonNumber)
        {
            _cutPlants.clickedOrder.Add(buttonNumber);
            ColorBlock myColor = gameObject.GetComponent<Button>().colors;

            myColor.normalColor = Color.green;

            gameObject.GetComponent<Button>().colors = myColor;
            _cutPlants.matchNum++;
        }

    }
}
