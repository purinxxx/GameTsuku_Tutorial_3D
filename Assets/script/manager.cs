using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour {

	public static int score = 0;

	public GameObject obstacle;
	public GameObject scoreobj;

	float timeOut = 2f;
	float timeElapsed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		timeElapsed += Time.deltaTime;
		if(timeElapsed >= timeOut) {
			LoadObstacle ();
			timeElapsed = 0.0f;
		}
		scoreobj.GetComponent<Text>().text = "SCORE : " + score.ToString();
	}

	void LoadObstacle () {
		GameObject obj = (GameObject)GameObject.Instantiate(obstacle) ;
		obj.transform.parent = transform;
		float y = Random.Range (-4f, 9f);
		obj.transform.localPosition = new Vector3(25, y, 0);
	}
}
