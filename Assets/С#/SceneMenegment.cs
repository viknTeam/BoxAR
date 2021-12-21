using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class SceneMenegment : MonoBehaviour
{
    public void GoToScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
        
    }

    

    public void Exit()
    {
        Application.Quit();
    }
    
}
