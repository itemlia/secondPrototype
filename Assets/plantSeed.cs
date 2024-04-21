using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class plantSeed : MonoBehaviour
{
   public GameObject seed;
   public GameObject waterBar;
   
   public Vector3 offset;
   public Vector3 scale;

   public float distance;
   private string planted = "planted";

   public TextMeshProUGUI textComp;
  
   private void Update()
   {
      raycastSeed();

      if (Input.GetMouseButton(1))
      {
         OnMouseDrag();
      }
      else if (Input.GetMouseButton(0) && seed.CompareTag("planted"))
      {
         OnMouseDown();
      }
   }

   private void OnMouseDrag()
      {
         seed.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - offset);
      }
   

   private void raycastSeed()
   {
      Debug.DrawRay(seed.transform.position, Vector2.down * distance, Color.black);
      
      RaycastHit2D down = Physics2D.Raycast(seed.transform.position, Vector2.down, distance);
      RaycastHit2D up = Physics2D.Raycast(seed.transform.position, Vector2.up, distance);
      RaycastHit2D left = Physics2D.Raycast(seed.transform.position, Vector2.left, distance);
      RaycastHit2D right = Physics2D.Raycast(seed.transform.position, Vector2.right, distance);

      if (up.transform != null && down.transform != null && left.transform != null && right.transform != null)
      {
         if (up.transform.CompareTag("ground") || down.transform.CompareTag("ground") ||
             left.transform.CompareTag("ground") || right.transform.CompareTag("ground"))
         {
            seed.tag = "planted";
            Debug.Log("planted");
            textComp.text = planted;
         }
      }
   }

   private void OnMouseDown()
   {
      waterBar.SetActive(true);
      waterBar.transform.localScale = waterBar.transform.localScale + scale;
   }
}

