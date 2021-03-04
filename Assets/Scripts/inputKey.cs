using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
            //Debug.Log works only in Unity, otherwise use print
            Debug.Log("Key down");
            //print("key down");

    }
}
