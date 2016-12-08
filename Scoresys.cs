using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scoresys : MonoBehaviour {
    public Text txt;
	float cursocre;
    
    
    

	// Use this for initialization
	void Start () {
        txt = GetComponent<Text>();
		cursocre = PlayerPrefs.GetFloat("Scor");
	
	}
	
	// Update is called once per frame
	void Update () {
		txt.text = "Score:" + cursocre;
        PlayerPrefs.SetFloat("Scor", cursocre);

    }
    public void AddScore(float sc)
    {
        cursocre += sc;
    }
    

}
