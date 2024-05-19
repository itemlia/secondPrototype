using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class cutPlantPrefabVer : MonoBehaviour
{
    // [SerializeField] private GameObject waterBar;
    // [SerializeField] private Button click;
    // [SerializeField] private GameObject invSlot;
    // [SerializeField] private GameObject seed;
    //
    // private void Awake()
    // {
    //     invSlot = GameObject.Find("inventory slot");
    //     waterBar = GameObject.Find("water b");
    //     seed = gameObject;
    // }
    //
    // public void OnMouseDown()
    // {
    //     waterBar.transform.localScale = new Vector3(0.0f, 0.33f, 1.0f);
    //     
    //     seed.transform.DetachChildren();
    //     //seed.transform.position = invSlot.transform.position;
    // }
    
    public TextMeshProUGUI textComp;
    public GameObject yesNO;
    public int price;
    public bool clicked;
    public GameObject seed;
    
    [SerializeField] private string sellingPrice;

    public void OnMouseDown()
    {
        yesNO.SetActive(true);
        textComp.text = sellingPrice;
        clicked = true;
    }

}
