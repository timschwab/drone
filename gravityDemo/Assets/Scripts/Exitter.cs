﻿using UnityEngine;
using System.Collections;

public class Exitter : MonoBehaviour {
	
	void Update ()
	{
		if (Input.GetKey(KeyCode.Escape))
			Application.Quit();
	}
}
