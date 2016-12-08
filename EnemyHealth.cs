using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
    public float health;
    float curhealth;
    public bool alive;
    public float score;

	// Use this for initialization
	void Start () {
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
            health = 0;
            alive = false;
            gameObject.SetActive(false);
            GameObject.FindObjectOfType<Scoresys>().AddScore(score);
        }
        curhealth -= amount;

    }
}
