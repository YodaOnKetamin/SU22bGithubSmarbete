using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectspawner : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;

    [SerializeField]
    Transform Spawnpoint;

    [SerializeField]
    KeyCode Space;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Space))
        {
            Instantiate(bullet, Spawnpoint.position, Quaternion.identity);
        }
       
    }

}
