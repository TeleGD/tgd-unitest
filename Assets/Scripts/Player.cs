using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float Hspeed;
    [SerializeField] private float Vspeed;
    [SerializeField] private bool isDead;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float velocityXmax=1;


    public GameObject hitup;
    public GameObject hitdown;

    [SerializeField]
    private bool triggerGround;

    private Vector2 moveDirection;
    private float moveVertical;

    private static int lives = 3;


    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        triggerGround = false;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        
        if (Mathf.Abs(rb.velocity.x)<=velocityXmax)
        {
            rb.AddForce(new Vector2( Hspeed* Input.GetAxis("Horizontal"),0)) ;
        }

        // Stocke l'entrée verticale dans la variable moveVertical.
        if (triggerGround && Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector2(0,  Vspeed),ForceMode2D.Impulse);
            triggerGround = false;
        }
    }

    public int getLives()
    {
        return lives;
    }

    public void setLives(int l)
    {
        lives = l;
    }

    public void setTriggerGround(bool b)
    {
        triggerGround = b;
    }

    public bool getTriggerGround()
    {
        return triggerGround;
    }
}
