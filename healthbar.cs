using UnityEngine;
using System.Collections;

public class healthbar : MonoBehaviour {
    float health;

	// Use this for initialization
	void Start () {
        



    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void TakeDamage()
    {
        transform.localScale = new Vector3((GameObject.FindObjectOfType<Healthsystem>().curhealth  / GameObject.FindObjectOfType<Healthsystem>().health), 1 , 1);
    }
}
