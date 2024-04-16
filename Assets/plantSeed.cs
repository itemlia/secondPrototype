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

   public void OnMouseDrag()
   {
      seed.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - offset);
   }

   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("ground"))
      {
         seed.tag = "planted";
      }
   }
}

