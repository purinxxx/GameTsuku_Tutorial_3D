using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.x -= 0.12f;
		transform.position = pos;
		if(transform.position.x < -25){
			Destroy(this.gameObject);
		}
	}
}
