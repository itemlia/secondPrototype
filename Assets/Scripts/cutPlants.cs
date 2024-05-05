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
    [SerializeField] private GameObject sellButton;
    
    [SerializeField] private bool listMatch = false;
    [SerializeField] public int matchNum;

    private void Update()
    {
        if (buttonOrder.Count != clickedOrder.Count) //compares the two lists to see if theyre the same
        {
            listMatch = false;
        }
        else  if (matchNum >= 5)
        {
            listMatch = true; //if all five numbers are correct then the lists are matched
        }
        if (listMatch) //if lists are matched then seed is 'harvested'
        {
            seed.transform.DetachChildren();
            seed.transform.position = slotOne.transform.position;
            buttons.SetActive(false);
            sellButton.SetActive(true);

        }
    }
}
