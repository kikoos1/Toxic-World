using UnityEngine;
using System.Collections;
using System.Timers;

public class startscreen : MonoBehaviour {
    Timer t = new Timer();

    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        t.Start();
        Application.LoadLevel("Loadscreen");
	}
}
