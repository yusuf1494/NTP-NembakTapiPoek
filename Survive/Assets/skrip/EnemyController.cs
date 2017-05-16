﻿using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	private Rigidbody myRB;
	public float moveSpeed;

	public PlayerControl thePlayer;

	// Use this for initialization
	void Start () 
	{
		myRB = GetComponent<Rigidbody>();
		thePlayer = FindObjectOfType<PlayerControl>();
	}
	void FixedUpdate()
	{
		myRB.velocity = (transform.forward * moveSpeed);
	}
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt(thePlayer.transform.position);
	}
}
