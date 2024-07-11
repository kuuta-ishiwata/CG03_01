using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public GameObject bullet;
    public Animator Animator;
    int bullettimer = 0;
    
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = 2.0f;
        float stageMax = 7.0f;
        if(Input.GetKey(KeyCode.RightArrow))
        {
            if(transform.position.x < stageMax)
            {
                rb.velocity = new Vector3(moveSpeed, 0, 0);
                Animator.SetBool("mode", true);
            }
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            if(transform.position.x < stageMax)
            {
                rb.velocity = new Vector3(-moveSpeed, 0, 0);
                Animator.SetBool("mode", true);
            }
        }

        else
        {
            rb.velocity = new Vector3(0, 0, 0);
            Animator.SetBool("mode", false);
        }

       
        Debug.Log(rb.velocity);

    }

    void FixedUpdate()
    {
        //’e”­ŽË
        if (bullettimer == 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
            
                Vector3 position = transform.position;
                position.y += 0.8f;
                position.z += 1.0f;
                Instantiate(bullet, position, Quaternion.identity);

                bullettimer = 1;
            }
        }
        else
        {
            bullettimer++;
            if(bullettimer>20)
            {
                bullettimer = 0;
            }
        }
        
    }
}
