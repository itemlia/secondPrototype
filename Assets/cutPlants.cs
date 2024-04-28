using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cutPlants : MonoBehaviour
{
    [SerializeField] private List<int> buttonOrder;
    [SerializeField] public List<int> clickedOrder;

    [SerializeField] private GameObject canvasEmpty;
    [SerializeField] private GameObject slotOne;
    [SerializeField] private GameObject seed;
    
    private bool listMatch = false;
    [SerializeField] private int matchNum;

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
            seed.transform.DetachChildren();
            canvasEmpty.SetActive(false);
            seed.transform.position = slotOne.transform.position;

        }
    }
}
