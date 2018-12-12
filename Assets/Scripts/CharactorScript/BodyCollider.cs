﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCollider : MonoBehaviour {

	private GrabController myGrabController;

	void Start() {
		myGrabController = GameObject.Find("GameManager").GetComponent<GrabController>();
	}
	void OnTriggerEnter(Collider other) {
		if (myGrabController.rightHandObjectGrabing() && myGrabController.rightHandObject == other.gameObject) {
			myGrabController.myTextWriter.writeText(GameObject.Find("GameManager").GetComponent<NarrativeController>().getObjectNarrative(other.gameObject.name));
			int count = PlayerPrefs.GetInt(other.gameObject.name+"_get",0);
			PlayerPrefs.SetInt(other.gameObject.name+"_get",count);
			myGrabController.rightHandObject = null;
			Destroy(other.gameObject); // myGrabController.rightHandObject
		}
		if (myGrabController.leftHandObjectGrabing() && myGrabController.leftHandObject == other.gameObject) { 
			myGrabController.myTextWriter.writeText(GameObject.Find("GameManager").GetComponent<NarrativeController>().getObjectNarrative(other.gameObject.name));
			int count = PlayerPrefs.GetInt(other.gameObject.name+"_get",0);
			PlayerPrefs.SetInt(other.gameObject.name+"_get",count);
			myGrabController.leftHandObject = null;
			Destroy(other.gameObject); // myGrabController.leftHandObject ??
		}
	}
}
