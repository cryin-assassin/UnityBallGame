﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

private bool isPaused = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Paused"))
		{
			if (isPaused)
			{
				Time.timeScale = 1;
				isPaused = false;
			}
			else
			{
					Time.timeScale = 0;
				isPaused = true;
			}

		}
	}


}
