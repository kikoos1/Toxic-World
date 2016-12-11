using UnityEngine;
using System.Collections;

public class enemyAtack : MonoBehaviour {
    public float damage;	
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Healthsystem>().TakeDamage(damage);
            gameObject.SetActive(false);
        }
        
    }
}
