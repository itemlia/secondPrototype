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
      RaycastHit2D down = Physics2D.CircleCast(can.transform.position, distance, Vector2.down, distance, 3);
      Debug.DrawRay(can.transform.position, Vector2.down * distance, Color.black);
      RaycastHit2D up = Physics2D.Raycast(can.transform.position, Vector2.up, distance);
      Debug.DrawRay(can.transform.position, Vector2.up * distance, Color.black);
      RaycastHit2D left = Physics2D.Raycast(can.transform.position, Vector2.left, distance);
      Debug.DrawRay(can.transform.position, Vector2.left * distance, Color.black);
      RaycastHit2D right = Physics2D.Raycast(can.transform.position, Vector2.right, distance);
      Debug.DrawRay(can.transform.position, Vector2.right * distance, Color.black);

      if (down.transform != null)
      {
         Debug.Log("hooray");
      }

      // if (up.transform != null && down.transform != null && left.transform != null && right.transform != null)
      // {
      //    while (up.transform.CompareTag("planted") || down.transform.CompareTag("planted") ||
      //           left.transform.CompareTag("planted") ||
      //           right.transform.CompareTag("planted"))
      //    {
      //       Debug.Log("hit");
      //       fillUpBar.SetActive(true);
      //       fillUpBar.transform.position = fillUpBar.transform.position - scale;
      //    }
      // }
   }
}

