﻿using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
    public float speed;
    public float jump;
    Rigidbody2D rb;
    Animator anim;
    bool facingright;
   

	// Use this for initialization
	void Start () {
        facingright = true;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update () {            
       
        
        
	
	}
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(speed,rb.velocity.y);
            anim.Play("walking");
            transform.localScale = new Vector3(1,1,1);
        }else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.Play("idle");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-speed,rb.velocity.y);
            anim.Play("walking");
            transform.localScale = new Vector3(-1,1,1);
        }else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.Play("idle");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
            anim.Play("jumping");
        }else if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.Play("idle");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            anim.Play("atacking");
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            anim.Play("idle");
        }
        
    }
   
}
