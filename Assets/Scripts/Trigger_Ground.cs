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
        print("couocou");
        p.setTriggerGround(true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
