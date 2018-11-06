using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Trying to set up the scene transition

public class SceneTransitions : MonoBehaviour
{
    public void SceneTransfer(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
