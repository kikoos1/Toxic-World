using UnityEngine;
using System.Collections;

public class Damagesystem : MonoBehaviour {
    public float damage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        col.gameObject.GetComponent<Healthsystem>().TakeDamage(damage);
    }

}
