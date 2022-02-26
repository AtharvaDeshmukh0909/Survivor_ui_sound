using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public void PlayAgain(){
        Debug.Log("clicked");
        SceneManager.LoadScene(4);
    }
    public void Quit(){
        Application.Quit();
    }
   
}