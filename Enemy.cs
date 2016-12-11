using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public GameObject enemy;
    public float detectiontime;
    public float startrun;
    bool firstDetection;
    public float runspeed;
    public float walkspeed;
    public bool facingRight = true;
    public float movespeed;
    public bool running;
    Rigidbody2D myrb;
    Animator anim;
    Transform target;
    bool Detected;
    public Transform firepoint;
    public Transform ball;
    public AudioSource ass;


    // Use this for initialization
    void Start()
    {
        myrb = GetComponentInParent<Rigidbody2D>();
        anim = GetComponentInParent<Animator>();
        running = false;
        Detected = false;
        ass = GetComponent<AudioSource>();
       
        

        firstDetection = false;
        movespeed = walkspeed;

        if (Random.Range(0, 10) > 5)
        {
            Flip();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = enemy.transform.localScale;
        theScale.x *= -1;
        enemy.transform.localScale = theScale;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" && !Detected)
        {
            Detected = true;
            target = other.transform;
            anim.Play("enemywalk");
            if(target.position.x < transform.position.x && facingRight)
            {
                Flip();
            }else if (target.position.x > transform.position.x && !facingRight)
            {
                Flip();
            }
            
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            firstDetection = false;
            if (running)
            {
                movespeed = walkspeed;
                running = false;
                Atack();
            }
        }
       
    }
    void FixedUpdate()
    {
        if (Detected)
        {
            if (target.position.x < transform.position.x && facingRight)
            {
                Flip();
            }
            else if (target.position.x > transform.position.x && !facingRight)
            {
                Flip();
            }
            if (!firstDetection)
            {
                startrun = Time.time + detectiontime;
                firstDetection = true;
            }
        }
        if(Detected && !facingRight)
        {
            myrb.velocity = new Vector3(movespeed * -1,myrb.velocity.y,0);

        }else if(Detected && facingRight)
        {
            myrb.velocity = new Vector3(movespeed, myrb.velocity.y, 0);

        }
        if(!running && Detected)
        {
            if(startrun < Time.time)
            {
                movespeed = runspeed;
                running = true;
            }
        }
        


        
    }
    void Atack()
    {
        Instantiate(ball,firepoint.position,firepoint.rotation);
        ass.Play();  
    }
}
