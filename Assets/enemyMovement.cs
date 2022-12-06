using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    float enemydirection = 0.25f;

    
    
    float timer = 0;
    float timer2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer2 += Time.deltaTime;
        timer += Time.deltaTime;
        if (timer > 1)
        {
            transform.position += new Vector3(enemydirection , 0, 0);
            timer = 0;
        }



        if (timer2 > 12)
        {
            transform.position -= new Vector3(0, 0.5f, 0);
            enemydirection *= -1;
            timer2 = 0;
            
        }
    }
}
