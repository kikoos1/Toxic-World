using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PauseM : MonoBehaviour {
    public Canvas pausemenu;
    public string Levels;
    public Slider sound;
    float soundlevel;
    public AudioSource AS;

	// Use this for initialization
	void Start () {
        pausemenu.enabled = false;
        sound.enabled = false;
       

	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausemenu.enabled = !pausemenu.enabled;
           
            Time.timeScale = 0;
            if (!pausemenu.enabled)
            {
                Time.timeScale = 1;
            }
        }
        PlayerPrefs.SetFloat("Volume", soundlevel);

        PlayerPrefs.GetFloat("Volume");
	
	}
    public void Resume()
    {
        Time.timeScale = 1;
        pausemenu.enabled = false;
    }
      public    void Returntommain()
    {
        Application.LoadLevel(Levels);
        Time.timeScale = 1;
    }
    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1;
    }
    public void Save()
    {
        PlayerPrefs.SetInt("Save", Application.loadedLevel);
        Time.timeScale = 1;
        Returntommain();

    }
   
}
