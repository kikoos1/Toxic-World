using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
    public AudioClip[] music;
    private AudioSource ass;

    

	// Use this for initialization
	void Start () {
        ass = FindObjectOfType<AudioSource>();
        ass.loop = false;
	
	}
    private AudioClip GetRandomClip()
    {
        return music[Random.Range(0,music.Length)];
    }
	
	// Update is called once per frame
	void Update () {
        if (!ass.isPlaying)
        {
            ass.clip = GetRandomClip();
            ass.Play();
        }
	
	}
}
