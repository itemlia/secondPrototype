using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wateringCanControls : MonoBehaviour
{
   public GameObject can;
   //public GameObject fillUpBar;
   public GameObject invSlot;

   public Vector3 offset;
   //public Vector3 scale;

   public Button waterCan;
   
   //public float distance;
   private void Update()
   {
      //waterPlant();
      var btn = waterCan.GetComponent<Button>();
      btn.onClick.AddListener(moveToInventory);
   }

   // private void OnMouseDrag()
   // {
   //    can.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - offset);
   // }

   public void moveToInventory()
   {
      can.transform.position = invSlot.transform.position;
      can.transform.parent = invSlot.transform;
   }
}


// private void waterPlant()
// {
//    RaycastHit2D down = Physics2D.CircleCast(can.transform.position, distance, Vector2.down, distance, 3);
//    Debug.DrawRay(can.transform.position, Vector2.down * distance, Color.black);
//    RaycastHit2D up = Physics2D.Raycast(can.transform.position, Vector2.up, distance);
//    Debug.DrawRay(can.transform.position, Vector2.up * distance, Color.black);
//    RaycastHit2D left = Physics2D.Raycast(can.transform.position, Vector2.left, distance);
//    Debug.DrawRay(can.transform.position, Vector2.left * distance, Color.black);
//    RaycastHit2D right = Physics2D.Raycast(can.transform.position, Vector2.right, distance);
//    Debug.DrawRay(can.transform.position, Vector2.right * distance, Color.black);
//
//    if (down.transform != null)
//    {
//       Debug.Log("hooray");
//    }
// }
