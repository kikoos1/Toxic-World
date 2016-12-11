using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Healthsystem : MonoBehaviour {
    public float health;
    public float curhealth;
    public bool alive;


	// Use this for initialization
	void Start () {
        health = 100;
        curhealth = health;
        alive = true;
        
	
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
           
        }
        curhealth -= amount;
        GameObject.FindObjectOfType<healthbar>().TakeDamage();
        
    }
   public void Healing(float healing)
    {
        if (curhealth <= 100)
        {
            curhealth += healing;
        }
        
    }
}
