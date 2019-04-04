using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Ground : MonoBehaviour
{
    public Player p;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        p.setTriggerGround(true);

        if (collision.gameObject.name=="ennemy_Body")
        {
            Ennemy enm = (Ennemy) collision.gameObject.transform.parent.gameObject.GetComponent("Ennemy");
            enm.getStomped();
        }
     
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
