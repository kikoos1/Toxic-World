using UnityEngine;
using System.Collections;

public class gameoverm : MonoBehaviour {
    public string mainm;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Return()
    {
        Application.LoadLevel(mainm);
    }
    public void Retry()
    {
        PlayerPrefs.SetFloat("Scor",0 );
        Application.LoadLevel(PlayerPrefs.GetInt("Save"));
    }
}
