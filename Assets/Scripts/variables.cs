using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour
{
    public string myName = "Loske";
    public int myAge = 26;
    public float speed = 5.2f;
    public int myHealth = 100;
    public int myScore = 50;
    public bool keyCollected = false;
    public int myAmmo = 1000;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is " + myName + " and my age is " + myAge);
        Debug.Log("The speed is " + speed);
        Debug.Log("The health is " + myHealth + "and my score is " + myScore + "and my ammo is " + myAmmo);
        Debug.Log("The ammo at the moment is " + myAmmo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
