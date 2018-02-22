using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour {
    public heroScript patatePlayer;
    [HideInInspector]
    public bool isCollided = false;

	void Start () {
        patatePlayer.GetComponent<heroScript>();
	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && patatePlayer.heroState == 0)
        {
            patatePlayer.heroState += 1;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ground_Touch") isCollided = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground_Touch") isCollided = false;
    }

}
