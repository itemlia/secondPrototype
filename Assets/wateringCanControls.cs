using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wateringCanControls : MonoBehaviour
{
   [SerializeField] private GameObject can;
   [SerializeField] private GameObject invSlot;

   [SerializeField] private Vector3 offset;

   [SerializeField] private Button waterCan;
   
   private void Update()
   {
      var btn = waterCan.GetComponent<Button>();
      btn.onClick.AddListener(moveToInventory);
   }

   

   public void moveToInventory()
   {
      can.transform.position = invSlot.transform.position;
      can.transform.parent = invSlot.transform;
   }
}

