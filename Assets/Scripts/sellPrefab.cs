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
    private GameObject waterBar;

    private void Update()
    {
        _shopManager = GameObject.Find("shop manager").GetComponent<shopManager>();
        waterBar = GameObject.Find("water b");
    }

    public void OnMouseDown()
    {
        waterBar.transform.localScale = new Vector3(0.0f, 0.33f, 1.0f);

        _shopManager.money += price;
        _shopManager.moneyCounter.text = _shopManager.money.ToString();
        textComp.text = "sold for " + price;
        //destroys the sold plant
        Transform parent = gameObject.transform.parent;
        Transform parentOfParent = parent.parent;
        Destroy(parentOfParent.gameObject, 1);
    }
}
