using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class level1 : MonoBehaviour {
    public Text txt;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        txt.text = "Level1:" + PlayerPrefs.GetInt("Scor");
	
	}
}
