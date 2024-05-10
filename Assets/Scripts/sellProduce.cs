using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;

public class sellProduce : MonoBehaviour
{
    public TextMeshProUGUI textComp;
    public GameObject yesNO;
    public int price;
    public bool clicked;
    
    [SerializeField] private string sellingPrice;

    public void OnMouseDown()
    {
        yesNO.SetActive(true);
        textComp.text = sellingPrice;
        clicked = true;
    }
}
