using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour {

	public void gamestart()
	{
		manager.score = 0;
		Application.LoadLevel ("play");
	}

	public void restart()
	{
		manager.score = 0;
		Application.LoadLevel ("play");
	}

	public void backtotitle()
	{
		Application.LoadLevel ("title");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
