﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBahviourScript : MonoBehaviour
{
   
    bool Otwarta=false;

   
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObcjet.CompareTag("Skrzynia")&& Input.GetKeyDown ( "E") && Otwarta==false)
        {
         //   other.sortingOrder=0;
            Otwarta=true;
        }
    }
     void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Dzban" && Input.GetKeyDown("mouse[0]" && Rozbite=false)
        {
            Debug.Log("");
            Rozbite = true;
        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "MyGameObjectTag")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}