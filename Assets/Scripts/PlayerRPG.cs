using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRPG : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private int vitesse = 0;
    private int timerPause;

    // Start is called before the first frame update
    void Start()
    {
        timerPause = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timerPause = Move(timerPause);
    }

    int Move(int oldPause)
    {
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            return (oldPause==0)?0:(oldPause+1) % vitesse;
        }
        else if (oldPause == 0)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                player.transform.Translate(1, 0, 0);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                player.transform.Translate(-1, 0, 0);
            }
            else if (Input.GetAxis("Vertical") > 0)
            {
                player.transform.Translate(0, 1, 0);
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                player.transform.Translate(0, -1, 0);
            }
        }   
        return (oldPause + 1) % vitesse;
    }

}
