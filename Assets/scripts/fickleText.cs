using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fickleText : MonoBehaviour {

    private SpriteRenderer img;
    public float timeFickle = 5f;
    private float timeFickleStart = 0f;

	// Use this for initialization
	void Start () {
        img = GetComponent<SpriteRenderer>();
        img.color = Color.clear;
	}
	
	// Update is called once per frame
	void Update () {
        makeAFickle();
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(1);
        }
	}

    void makeAFickle()
    {
        timeFickleStart += Time.deltaTime;
        if (timeFickleStart >= timeFickle)
        {
            timeFickleStart = 0f;
            img.color = (img.color == Color.clear) ? Color.white : Color.clear;
        }
    }

}
