using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class finalscore : MonoBehaviour {
    public Text txt;
    
	// Use this for initialization
	void Start () {
        txt.text = "Score:" + PlayerPrefs.GetFloat("Scor");
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
}
