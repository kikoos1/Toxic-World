using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Play()
    {
        PlayerPrefs.SetFloat("Scor", 0);
        Application.LoadLevel("Level1");
        
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Load()
    {
        Application.LoadLevel(PlayerPrefs.GetInt("Save"));
    }public void Tutorial()
    {
        Application.LoadLevel("Tutorial");
    }

}
