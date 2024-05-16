using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemArray : MonoBehaviour
{
   public List<GameObject> boughtItems;
   
   private void Awake()
   {
      var itemArrayMang = FindObjectsOfType<itemArray>().Length; //sttops the shop manager from duplicating

      if (itemArrayMang > 1)
      {
         Destroy(gameObject);
      }
      else
      {
         DontDestroyOnLoad(gameObject);
      }
   }
}
