using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public Transform Maxpos;
    public Transform Minpos;

    public float inc = 3f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move();

    }
    private void move()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {

            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, Minpos.position.x, Maxpos.position.x), transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {

            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, Minpos.position.x, Maxpos.position.x), transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene(0);

        }
    }
}


          
     


