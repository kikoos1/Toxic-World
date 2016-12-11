using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour
{
    public float speed;
    GameObject enemy;
    Rigidbody2D rb;
    public float delay;
    


    // Use this for initialization
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        enemy = FindObjectOfType<Enemy>().enemy;
        if (enemy.transform.localScale.x > 0)
        {
            speed *= -1;
        }




    }

    // Update is called once per frame
    void Update()
    {
       
        rb.velocity = new Vector2(speed,rb.velocity.y);
        Destroy(gameObject, delay);

    }
}
        
	
	

