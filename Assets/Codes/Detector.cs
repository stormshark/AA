using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{

    GameObject donencember;
    GameObject gamecontroller;
    public static int cemberdekiIgne=0;
    public static bool oyunadevam { get; set; }


    private void Start()
    {
         donencember = GameObject.FindGameObjectWithTag("TagSilindir");
      gamecontroller = GameObject.FindGameObjectWithTag("GameController");

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TagSilindir"))
        {
            Rigidbody2D ourGameObjectRB = GetComponent<Rigidbody2D>();
            transform.SetParent(collision.gameObject.transform);
            cemberdekiIgne = +1;
            ourGameObjectRB.isKinematic = true;
        }
        else if (collision.CompareTag("TagIgne") && (collision.transform.parent==null))
        {
            Debug.Log("oyun devam");
            
        }

        else
        {
              oyunadevam = false;
              donencember.GetComponent<Rotater>().enabled = false;
              Debug.Log("oyun BİTİİİİİİİİİİ");
              gamecontroller.GetComponent<Initilize>().GameOver();

        }
    }

}
