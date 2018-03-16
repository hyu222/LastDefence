﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 5f;

    // Use this for initialization
    void Start()
    {
    }
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        Destroy();
	}

    void Destroy ()
    {
        Destroy(gameObject, 5);
    }
}
