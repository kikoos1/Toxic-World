using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class addscore : MonoBehaviour {
    public int score;
	// Use this for initialization
	void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update () {
       if(GameObject.FindObjectOfType<Healthsystem>().curhealth <= 0)
        {
            GameObject.FindObjectOfType<Scoresys>().AddScore(score);
        }

	
	}
}
