using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    [SerializeField]
    string nextLevel = "";

    int lives;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {

        loadLevel();
        
    }

    private void loadLevel()
    {
        SceneManager.LoadScene(this.nextLevel);

    }
}

