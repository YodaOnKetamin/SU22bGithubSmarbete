using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    Score score;
    
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( score.score == 600)
        {
            SceneManager.LoadScene("Win");
        }

     }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy" || collision.tag == "Enemy2" || collision.tag == "Enemy3")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
