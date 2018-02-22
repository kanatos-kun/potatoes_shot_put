using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAroundMouse : MonoBehaviour {
    private Camera cam;

	// Use this for initialization
	void Start () {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
	}

    // Update is called once per frame
    void Update () {
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = transform.position.z;
       // Debug.Log("mouse position x : " + mousePos.x + ", mouse position y : " + mousePos.y + ", mouse position z : " + mousePos.z);
        transform.position = mousePos;
       
	}
}
