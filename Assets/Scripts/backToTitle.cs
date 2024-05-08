using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class backToTitle : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Scenes/title");
    }
}
