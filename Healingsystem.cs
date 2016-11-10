using UnityEngine;
using System.Collections;

public class Healingsystem : MonoBehaviour {
    public float heal;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<Healthsystem>().Healing(heal);
        GameObject.FindGameObjectWithTag("Health").SetActive(false);
    }
}
