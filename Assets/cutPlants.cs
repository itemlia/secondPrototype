using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cutPlants : MonoBehaviour
{
    public List<int> buttonOrder;
    public List<int> clickedOrder;

    private void Start()
    { 
        buttonOrder.Add(1);
        buttonOrder.Add(4);
        buttonOrder.Add(2);
        buttonOrder.Add(5);
        buttonOrder.Add(3);
    }
}
