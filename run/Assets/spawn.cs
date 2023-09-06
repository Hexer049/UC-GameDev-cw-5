using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
   
    public Transform Maxpos;
    public Transform Minpos;
    public Transform Midpos;
    public GameObject Enemy;
    public float delay = 1;



    void Start()
    {
        InvokeRepeating("Spawn", 0f, delay);
         

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        int Randompos = Random.Range(1 , 4);
        if (Randompos == 1)
        {
            Instantiate(Enemy, Midpos);

        }
       else if (Randompos == 2)
        {
            Instantiate(Enemy, Maxpos);

        }
       else if (Randompos == 3)
        {
            Instantiate(Enemy, Minpos);

        }


    }

}
