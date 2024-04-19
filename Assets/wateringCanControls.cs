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

   public Transform line;
   public LineRenderer lineRender;
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

      // lineRender.enabled = true;
      // lineRender.SetPosition(distance, can.transform.position);
      
      RaycastHit2D down = Physics2D.Raycast(can.transform.position, Vector2.down, distance);
      Debug.DrawRay(can.transform.position, Vector2.down * distance, Color.black);
      RaycastHit2D up = Physics2D.Raycast(can.transform.position, Vector2.up, distance);
      Debug.DrawRay(can.transform.position, Vector2.up, Color.black);
      RaycastHit2D left = Physics2D.Raycast(can.transform.position, Vector2.left, distance);
      Debug.DrawRay(can.transform.position, Vector2.left, Color.black);
      RaycastHit2D right = Physics2D.Raycast(can.transform.position, Vector2.right, distance);
      Debug.DrawRay(can.transform.position, Vector2.right, Color.black);
      
      if (up.transform != null && down.transform != null && left.transform != null && right.transform != null)
      {
         if (up.transform.CompareTag("planted"))
         {
            Debug.Log("up");
         } 
         else if (down.transform.CompareTag("planted"))
         {
            Debug.Log(("down"));
         }
         else if (left.transform.CompareTag("planted"))
         {
            Debug.Log(("left"));
         }
         else if (right.transform.CompareTag("planted"))
         {
            Debug.Log(("right"));
         }
         
      }
      
      // // RaycastHit2D hit = Physics2D.Raycast(can.transform.position, Vector2.down, distance);
      // Debug.DrawRay(can.transform.position, Vector2.down, Color.black);
      // if (hit.transform!= null)
      // {
      //    while (hit.transform.CompareTag("planted"))
      //    {
      //       Debug.Log("hit");
      //       //fillUpBar.SetActive(true);
      //       //fillUpBar.transform.position = fillUpBar.transform.position - scale;
      //    }
      // }
   }
}
