using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDeplacement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private bool isDead;

    [SerializeField]
    private Rigidbody2D rb;

    Vector2 moveDirection;


    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
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
        float moveVertical = Input.GetAxis ("Vertical");

        // Utilise les deux nombres pour créer un Vector2.
        moveDirection = new Vector2 (moveHorizontal, moveVertical);

        // Appelle la fonction AddForce() du Rigidbody2D rb avec le mouvement multiplié par la vitesse.
        rb.AddForce (moveDirection * speed);
    }
}
