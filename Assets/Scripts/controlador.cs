using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class controlador : MonoBehaviour
{
   public void nextScene(string nameScene){
       SceneManager.LoadScene(nameScene);
    }

    public void exitAPP(){
        Application.Quit();
    }
}
