using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowManyButtonScript : MonoBehaviour {
    public void ClickTest()
    {
        //linking up buttons
        Debug.Log("How many button clicked");
    }

    //keeping in for testing
    public void ClickTest2(string text)
    {
        Debug.Log(text);
    }
    //method to change scenes on button click 
    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
        // Use this for initialization
    }
}
