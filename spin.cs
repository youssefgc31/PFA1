﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(7, 10, 60) * Time.deltaTime);
		
	}
}
