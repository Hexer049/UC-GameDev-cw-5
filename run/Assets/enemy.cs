using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class enemy : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] float speed = - 10f;



    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    void Move()
    {
        rb.velocity = new Vector3(0f, 0f, speed);


    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene(0);


        }



    }


    
}  
    
