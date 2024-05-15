using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leaveShop : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Scenes/level1");
    }
}
