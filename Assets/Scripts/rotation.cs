﻿using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {

    [SerializeField]
    float velocity = 50.0f;

    Transform myTransform;

	// Use this for initialization
	void Start () {
        myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        myTransform.Rotate(0, velocity * Time.deltaTime, 0);
	}
}
