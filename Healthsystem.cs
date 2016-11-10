using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Healthsystem : MonoBehaviour {
    public float health;
    public float curhealth;
    Slider healthbar;
    public bool alive;


	// Use this for initialization
	void Start () {
        health = 100;
        curhealth = health;
        alive = true;
        healthbar.value = curhealth;
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
   public void TakeDamage(float amount)
    {
        if (!alive)
        {
            return;
        }
        if (curhealth <= 0)
        {
            curhealth = 0;
            alive = false;
            gameObject.SetActive(false);
            healthbar.gameObject.SetActive(false);
        }
        curhealth -= amount;
        healthbar.value = curhealth;
    }
   public void Healing(float healing)
    {
        if (curhealth <= 100)
        {
            curhealth += healing;
        }
        healthbar.value = curhealth;
    }
}
