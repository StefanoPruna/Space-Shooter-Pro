﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && pause == false)
        {
            Time.timeScale = 0;
            pause = true;
        }           
        else if (Input.GetKeyDown(KeyCode.P) && pause == true)
        {
            Time.timeScale = 1;
            pause = false;
        }
        
    }
}
