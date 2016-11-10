using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
    Rigidbody2D rb;
    public float speed;
    public float jump;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if (rb.velocity.x > 0)
        {
            transform.localScale = new Vector3(1f,1f,1f);
        }else if (rb.velocity.x < 0)
        {
            transform.localScale = new Vector3(-1f,1f,1f);
        }
        
	
	}
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, jump);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        
    }
}
