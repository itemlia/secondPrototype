using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cutPlants : MonoBehaviour
{
    public Vector3 offset;

    public GameObject seed;

    public float distance;
    private void Update()
    {
        rayCastChop();
        
        if (Input.GetMouseButton(1))
        {
            OnMouseDrag();
        } 
        else if (Input.GetMouseButtonDown(0) && gameObject.CompareTag("chop"))
        {
            OnMouseDown();
        }
    }

    private void rayCastChop()
    {
        RaycastHit2D raycast = Physics2D.Raycast(gameObject.transform.position, Vector2.down, distance);
        
        if (raycast.transform != null)
        {
            if (raycast.transform.CompareTag("planted"))
            {
                gameObject.tag = "chop";   
            }
        }
    }
    
    private void OnMouseDrag()
    {
        gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - offset);
    }

    private void OnMouseDown()
    {
        //RaycastHit2D raycast2 = Physics2D.queriesHitTriggers(true);
        seed.transform.DetachChildren();
        
    }
    
    
}
