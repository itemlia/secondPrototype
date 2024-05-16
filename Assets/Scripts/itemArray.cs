using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class itemArray : MonoBehaviour
{
   public List<GameObject> boughtItems;

   [SerializeField] private string currentSceneName;
   
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

      currentSceneName = SceneManager.GetActiveScene().name;

      if (currentSceneName == "level 1")
      {
         for(int i = 0; i < boughtItems.Count; i++)
         {
            Instantiate(boughtItems[i]);
         }
      }
      
   }
   
   
}
