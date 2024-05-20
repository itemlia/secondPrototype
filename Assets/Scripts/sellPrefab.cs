using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class sellPrefab : MonoBehaviour
{
    [SerializeField] private int price;
    [SerializeField] private TextMeshProUGUI textComp;
    private shopManager _shopManager;

    private void Update()
    {
        _shopManager = GameObject.Find("shop manager").GetComponent<shopManager>();
    }

    public void OnMouseDown()
    {
        _shopManager.money += price;
        _shopManager.moneyCounter.text = _shopManager.money.ToString();
        textComp.text = "sold for " + price;
        Transform parent = gameObject.transform.parent;
        Transform parentOfParent = parent.parent;
        Destroy(parentOfParent.gameObject, 3);
    }
}
