using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    [SerializeField]
    public string nextLevel = "";

    [SerializeField]
    public int complimentarylives=0;

    int lives;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player p = collision.gameObject.GetComponentInParent<Player>();
            p.setLives(p.getLives() + complimentarylives);
            print("Lives : " +lives);
            loadLevel();
        }
    }

    private void loadLevel()
    {
        SceneManager.LoadScene(this.nextLevel);
    }
}

