﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftGrabberColliderTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "item0")
        {
            GrabController.itemGrabFlg = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "item0")
        {
            GrabController.itemGrabFlg = false;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
