﻿using UnityEngine;
using System.Collections;

public class GaleInBed : MonoBehaviour {

	public float frequency = 6.0f;
	float timeStart;
	// Use this for initialization
	void Start () {
		timeStart = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > timeStart + frequency) {
			Bubble.DisplayMessage("zzzz", transform.position + new Vector3(3f, 1f, 0f));
			timeStart = Time.time;
		}
	}
}
