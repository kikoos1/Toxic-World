using UnityEngine;
using System.Collections;

public class dead : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.gameObject.GetComponent<Healthsystem>().TakeDamage(1000);
        }
        else if (other.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyHealth>().TakeDamage(1000);
        }
    }
}
