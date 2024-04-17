using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class plantSeed : MonoBehaviour
{
   public GameObject seed;
   public Vector3 offset;

   public float distance;

   public void OnMouseDrag()
   {
      seed.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - offset);
   }

   private void raycastSeed()
   {
      RaycastHit2D down = Physics2D.Raycast(seed.transform.position, Vector2.down, distance);
      RaycastHit2D up = Physics2D.Raycast(seed.transform.position, Vector2.up, distance);
      RaycastHit2D left = Physics2D.Raycast(seed.transform.position, Vector2.left, distance);
      RaycastHit2D right = Physics2D.Raycast(seed.transform.position, Vector2.right, distance);

      if (up.transform == null && down.transform == null && left.transform == null && right.transform == null) return;
      if (up.transform.CompareTag("ground") || down.transform.CompareTag("ground") ||
          left.transform.CompareTag("ground") || right.transform.CompareTag("ground"))
      {
            
      }
   }
}

