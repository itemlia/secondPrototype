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

    [SerializeField] private string sellingPrice;

    [SerializeField] private GameObject backgroundImage;
    [SerializeField] private GameObject inputField;

    public int price;

    public void OnMouseDown()
    {
        backgroundImage.SetActive(true);
        inputField.SetActive(true);
        textComp.text = sellingPrice;
    }
}
