using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void OynaGit()
    {
        SceneManager.LoadScene("lvl1");
    }


    public void Cik()
    {
        Application.Quit();
    }
}
