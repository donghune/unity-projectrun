using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{   
    public void LoadToScene(int sceneToLoad)
    {
        //Application.LoadLevel(sceneToLoad);
        SceneManager.LoadScene(sceneToLoad);
    }
}
