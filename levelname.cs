﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class levelname : MonoBehaviour {
    public Text txt;

	// Use this for initialization
	void Start () {
        txt.text = Application.loadedLevelName;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
