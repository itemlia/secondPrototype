using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontDest : MonoBehaviour
{
    private void Awake()
    {
        var dontDestCount = FindObjectsOfType<dontDest>().Length; //sttops the item manager from duplicating

        if (dontDestCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
        
        
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        var currentScene = SceneManager.GetActiveScene().name;

        if (currentScene != "level1") //if there are any items in use they wont be active n=in the shop level
        {
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(false);
            }
        }
        else
        {
            foreach (Transform child in transform)//items will then become active when back in main level
            {
                child.gameObject.SetActive(true);
            }
        }
    }
}
