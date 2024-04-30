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
    public Image backgroundImage;
    
    public void OnMouseDown()
    {
        backgroundImage.enabled = true;
        textComp.text = sellingPrice;
    }
}
