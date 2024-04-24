using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class clickingOrder : MonoBehaviour
{
    public int buttonNumber;

    public cutPlants _cutPlants;
    
    
    public void OnMouseDown()
    {
        _cutPlants.clickedOrder.Add(buttonNumber);
    }
}
