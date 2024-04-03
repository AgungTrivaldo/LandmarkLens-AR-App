using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene5 : MonoBehaviour
{
    public void exit (){
        Application.Quit();
        Debug.Log("App Close");

    }
    public void start () {
        SceneManager.LoadScene("Scene 62");

    }

    public void tutorial () {
        SceneManager.LoadScene("Scene 2");

    }
}
