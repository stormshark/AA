using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Initilize : MonoBehaviour
{
    public GameObject prefab;
    public float speed;
    Rigidbody2D rigid;
    GameObject createdObject;
    public Animator animator;
    public int needlesoncylinder;
    int istenenigneadet;
    public Text deneme;
    GameObject donencember;

    private void Start()
    {
        istenenigneadet = needlesoncylinder;
        deneme.text = needlesoncylinder.ToString();

    }

    void FixedUpdate()
    {

        if (needlesoncylinder > 0 )
        {
            if (Input.GetButtonDown("Fire1"))
            {

                needlesoncylinder -= 1;
                Instantiate(prefab).GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed);
                deneme.text = needlesoncylinder.ToString();
                               
            }
        }
        else
        {
            if (Comparer())
            {
                Debug.Log("kazandınız. Bir sonraki bölüm");
                StartCoroutine(Example());


            }
        }



    }
           
   public void GameOver()
    {
        Debug.Log("oyun bitti");
        animator.SetTrigger("GameOver");

    }

    IEnumerator Example()
    {
        Debug.Log("Before Waiting 2 seconds");
        yield return new WaitForSeconds(2.0f);
        Debug.Log("After Waiting 2 Seconds");
        SceneManager.LoadScene("lvl3");

    }
    public bool Comparer()
    {
        if (Mathf.Abs((needlesoncylinder - Detector.cemberdekiIgne))< istenenigneadet)
        {
            return true;
        }
        else
            return false;
        
    }


}
