using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float Hspeed;
    [SerializeField]
    private float Vspeed;

    [SerializeField]
    private bool isDead;

    [SerializeField]
    private Rigidbody2D rb;
    public GameObject hitup;
    public GameObject hitdown;

    [SerializeField]
    private bool triggerGround;

    private Vector2 moveDirection;
    private float moveVertical;


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
        // Stocke l'entrée horizontale dans la variable moveHorizontal.
        float moveHorizontal = Input.GetAxis ("Horizontal");

        // Stocke l'entrée verticale dans la variable moveVertical.
        if (triggerGround && Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector2(0, 1 * Vspeed),ForceMode2D.Impulse);
            triggerGround = false;
        }


        // Utilise les deux nombres pour créer un Vector2.
        moveDirection = new Vector2 (moveHorizontal*Hspeed, moveVertical*Vspeed);

        // Appelle la fonction AddForce() du Rigidbody2D rb avec le mouvement multiplié par la vitesse.
        rb.AddForce(moveDirection);
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
