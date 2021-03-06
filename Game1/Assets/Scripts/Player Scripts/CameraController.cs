﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject PlayerTank;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - PlayerTank.transform.position;        //keeps the main camera on the player at all times without spinning with the asteroid
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = PlayerTank.transform.position + offset;
	}
}
