﻿using UnityEngine;
using System.Collections;

public class orbitSat02 : MonoBehaviour {

	float rotationSpeed = 10.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(rotationSpeed * Vector3.up * Time.deltaTime);
	}
}
