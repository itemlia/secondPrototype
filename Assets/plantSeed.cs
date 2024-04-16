using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class plantSeed : MonoBehaviour
{
   public GameObject seed;
   

   public void OnMouseDrag()
   {
      seed.transform.position = Input.mousePosition;
   }
}
