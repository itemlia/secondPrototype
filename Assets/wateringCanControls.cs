using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wateringCanControls : MonoBehaviour
{
   public GameObject can;
   public GameObject fillUpBar;
   
   public Vector3 offset;
   public Vector3 scale;

   public float distance;

   private void Update()
   {
      waterPlant();
   }

   private void OnMouseDrag()
   {
      can.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - offset);
   }

   private void waterPlant()
   {
      RaycastHit2D hit = Physics2D.Raycast(can.transform.position, Vector2.down, distance);
      Debug.DrawRay(can.transform.position, Vector2.down, Color.black);
      if (hit.transform!= null)
      {
         while (hit.transform.CompareTag("planted"))
         {
            fillUpBar.SetActive(true);
            fillUpBar.transform.position = fillUpBar.transform.position - scale;
         }
      }
   }
}
