using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public GameObject canvas;

	// Use this for initialization
	void Start () {
		canvas.GetComponent<Canvas>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GetComponent<Rigidbody>().AddForce(0,600,0);
		}
	}

	void OnBecameInvisible () {
		Destroy(this.gameObject);
		Debug.Log ("死亡");
		canvas.GetComponent<Canvas>().enabled = true;
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("tuuka")) {
			manager.score++;
		} else if (other.gameObject.CompareTag ("obstacle")) {
			Destroy (this.gameObject);
		}
	}
}
