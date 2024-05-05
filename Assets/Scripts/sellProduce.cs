using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class sellProduce : MonoBehaviour
{
    public TextMeshProUGUI textComp;
    public GameObject backgroundImage;
    public int price;
    public bool clicked;
    
    [SerializeField] private GameObject inputField;
    [SerializeField] private string sellingPrice;
    [SerializeField] private inputPrice _inputPrice;

    public void OnMouseDown()
    {
        backgroundImage.SetActive(true);
        inputField.SetActive(true);
        textComp.text = sellingPrice;
        clicked = true;
        _inputPrice.getSeed();
    }
}
