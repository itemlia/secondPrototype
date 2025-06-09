using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class exitGame : MonoBehaviour
{
  [SerializeField] private Button exit;

  public void close()
  {
    Application.Quit();
  }

  private void Start()
  {
      var btn = exit.GetComponent<Button>();
      btn.onClick.AddListener(close);
      close();
  }
}
