using UnityEngine;
using System.Collections;

public class enemyball : MonoBehaviour {
    public float speed;
    Rigidbody2D rb;
    Enemy enemy;

	// Use this for initialization
	void Start () {
        enemy = GetComponent<Enemy>();
        rb = GetComponent<Rigidbody2D>();
        if(enemy.enemy.transform.localScale.x > 0)
        {
            speed = -speed;
        }
	
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(speed, rb.velocity.y);
	}
}
