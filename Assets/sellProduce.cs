using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class sellProduce : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComp;

    [SerializeField] private string sellingPrice;
    
    [SerializeField] private GameObject backgroundImage;
    
    public void OnMouseDown()
    {
        backgroundImage.SetActive(true);
        textComp.text = sellingPrice;
    }
}
