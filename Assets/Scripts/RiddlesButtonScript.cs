using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddlesButtonScript : MonoBehaviour {


    //testing to make sure all buttons linked up
    public void ClickTest()
    {
        Debug.Log("Riddles button clicked");
    }

    //single argument onclick function
    public void ClickTest2(string text)
    {
        Debug.Log(text);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
