using UnityEngine;
using System.Collections;

public class levels : MonoBehaviour {
    public string Levels;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Application.LoadLevel(Levels);
        }
        
    }
}
