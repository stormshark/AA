using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // StartCoroutine(Example());

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            StartCoroutine(Example());

        }
    }

    IEnumerator Example()
    {
        Debug.Log("Before Waiting 2 seconds");
        yield return new WaitForSeconds(2.0f);
        Debug.Log("After Waiting 2 Seconds");
        yield return new WaitForSeconds(2.0f);
    }
}
