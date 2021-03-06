﻿using UnityEngine;
using System.Collections;

	

public class Arrow : MonoBehaviour {
	public GameObject nextRoom;

	void OnMouseDown() {
		Camera.main.GetComponent<CameraMovement>().MoveTo(
			nextRoom.GetComponentInChildren <RoomObjectManager>().cameraPosition,
			delegate() {
				nextRoom.gameObject.SetActive(true);
			});
		gameObject.GetComponentInChildren<Renderer>().material.color = Color.white;
		gameObject.transform.parent.gameObject.SetActive(false);
	}
}



//Camera.main.transform.position = nextRoom.GetComponentInChildren<RoomObjectManager>().cameraPosition;