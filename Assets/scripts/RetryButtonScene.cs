using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class RetryButtonScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    public void changeScene(int index)
    {
        SceneManager.LoadScene(index);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
