using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fruitmanager : MonoBehaviour
{

    private void Update()
    {
        frutascollection();
    }

    public void frutascollection()
    {
        if(transform.childCount==0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
