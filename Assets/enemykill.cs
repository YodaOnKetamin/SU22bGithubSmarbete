using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemykill : MonoBehaviour
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

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            score.score += 20;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.tag == "Enemy2")
        {
            score.score += 30;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.tag == "Enemy3")
        {
            score.score += 40;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}