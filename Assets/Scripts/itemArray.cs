using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class itemArray : MonoBehaviour
{
   public List<GameObject> boughtItems;

   [SerializeField] private string currentSceneName;

   private void Update()
   {
      currentSceneName = SceneManager.GetActiveScene().name; //gets current scene name

      if (currentSceneName == "level1") //if we're in the right scene the bought items will be instantiated
      {
         while (boughtItems.Count > 0) //as long as theres at least one item in the list the items will get instantiated into the main scene
         {
            for (int i = 0; i < boughtItems.Count; i++)
            {
               Debug.Log(boughtItems[i]);
               Instantiate(boughtItems[i]);
               boughtItems.Remove(boughtItems[i]);

            }
         }
         
      }
      
   }

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
