using UnityEngine;
using System.Collections;

public class armatack : MonoBehaviour {

    public float damage;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            
            other.GetComponent<Healthsystem>().TakeDamage(damage);
        }
    }
   
}
