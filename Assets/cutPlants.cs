using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cutPlants : MonoBehaviour
{
    [SerializeField] public List<int> buttonOrder;
    [SerializeField] public List<int> clickedOrder;
    
    [SerializeField] private GameObject slotOne;
    [SerializeField] private GameObject seed;
    [SerializeField] private GameObject buttons;
    
    [SerializeField] private bool listMatch = false;
    [SerializeField] public int matchNum;

    private void Update()
    {
        if (buttonOrder.Count != clickedOrder.Count)
        {
            listMatch = false;
        }
        else  if (matchNum >= 5)
        {
            listMatch = true;
        }
            // for (int i = 0; i < 5; i++)
            // {
            //     if (buttonOrder[i] == clickedOrder[i])
            //     {
            //         matchNum++;
            //     }
            //     else
            //     {
            //         clickedOrder.Remove(i);
            //     }
            // }
        
        if (listMatch)
        {
            seed.transform.DetachChildren();
            seed.transform.position = slotOne.transform.position;
            buttons.SetActive(false);

        }
    }
}
