using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitShop : MonoBehaviour
{
    [SerializeField] private GameObject yesNo;
    
    public void OnMouseDown()
    {
        yesNo.SetActive(false);
        gameObject.SetActive(false);
    }
}
