using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public GameObject canvas;
	float v=0f;

	// Use this for initialization
	void Start () {
		canvas.GetComponent<Canvas>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		v -= 0.01f;
		if (Input.GetMouseButtonDown (0)) {
			//v += 0.5f;
			v=0.29f;
			//GetComponent<Rigidbody>().AddForce(0,600,0);
		}
		Vector3 pos = transform.position;
		pos.y += v;
		transform.position = pos;
	}

	void OnBecameInvisible () {
		Destroy(this.gameObject);
		Debug.Log ("game over");
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
