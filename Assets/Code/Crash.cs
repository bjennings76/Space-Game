using System;
using UnityEngine;
using System.Collections;

public class Crash : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("ship", StringComparison.OrdinalIgnoreCase))
        {
            Debug.Log("Congradulations you've lost!");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
