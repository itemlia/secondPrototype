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
    [SerializeField] private audioManager _audioManager;

    private void Update()
    {
        _audioManager = GameObject.Find("level 1 audio").GetComponent<audioManager>();
    }

    public void OnMouseDown()
    {
        if (_cutPlants.buttonOrder[_cutPlants.clickedOrder.Count] == buttonNumber) //checks individual list values when clicked
        {
            _audioManager.audios[1].Play();
            
            _cutPlants.clickedOrder.Add(buttonNumber); //if value is right then added to list and button is turnt green
            ColorBlock myColor = gameObject.GetComponent<Button>().colors;

            myColor.normalColor = Color.green;

            gameObject.GetComponent<Button>().colors = myColor;
            _cutPlants.matchNum++; //match number increases to show a match has been made
        }

    }
}
