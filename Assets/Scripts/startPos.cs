using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startPos : MonoBehaviour
{
    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        //modify the start position here
        //transform.position = new Vector3(0, 0, 0);

        //modify the position in the Unity/Inspector
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
