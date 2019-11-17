using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
  
    public float speed;
    Rigidbody2D rigid;

    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }



    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
           // rigid.MovePosition(Vector2.up * speed * Time.deltaTime);
            rigid.AddForce(Vector2.up * speed );
        }

    }
}

