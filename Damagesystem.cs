using UnityEngine;
using System.Collections;

public class Damagesystem : MonoBehaviour {
    public float damage;
    public EdgeCollider2D col;
    Animator anim;
  

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
   public void OnTriggerEnter2D(Collider2D other)
    {
        
        other.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage);
        
        
      
    }
    public void Atack()
    {
        col.enabled = !col.enabled;
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.C))
        {
            
            Atack();
        }
        
    }

}
