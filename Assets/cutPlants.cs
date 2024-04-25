using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cutPlants : MonoBehaviour
{
    public List<int> buttonOrder;
    public List<int> clickedOrder;

    public GameObject canvasEmpty;
    public GameObject slotOne;
    
    private bool listMatch = false;
    private int matchNum;

    private void Start()
    { 
        buttonOrder.Add(1);
        buttonOrder.Add(4);
        buttonOrder.Add(2);
        buttonOrder.Add(5);
        buttonOrder.Add(3);
    }

    private void Update()
    {
        if (buttonOrder.Count != clickedOrder.Count)
        {
            listMatch = false;
        }
        else
        {
            for (int i = 0; i < buttonOrder.Count; i++)
            {
                if (buttonOrder[i] == clickedOrder[i])
                {
                    matchNum++;
                }
                else
                {
                    listMatch = false;
                    break;
                }
            }
        }

        if (matchNum == 5)
        {
            listMatch = true;
        }

        if (listMatch)
        {
            gameObject.transform.DetachChildren();
            canvasEmpty.SetActive(false);
            gameObject.transform.position = slotOne.transform.position;

        }
    }
}
