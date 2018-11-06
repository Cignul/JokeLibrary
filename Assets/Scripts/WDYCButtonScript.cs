using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WDYCButtonScript : MonoBehaviour {
    //experimenting with onclick
    //no argument function
	public void ClickTest()
    {
        Debug.Log("what do you call button clicked");
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
