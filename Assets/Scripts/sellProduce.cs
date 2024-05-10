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
    public GameObject backgroundImage;
    public int price;
    public bool clicked;
    
    [SerializeField] private GameObject yesBtn;
    [SerializeField] private GameObject noBtn;
    
    [SerializeField] private string sellingPrice;
    
    [SerializeField] private inputPrice _inputPrice;

    public void OnMouseDown()
    {
        backgroundImage.SetActive(true);
        yesBtn.SetActive(true);
        noBtn.SetActive(true);
        textComp.text = sellingPrice;
        clicked = true;
    }
}
