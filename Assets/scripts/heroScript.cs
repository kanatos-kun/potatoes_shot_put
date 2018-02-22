using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heroScript : MonoBehaviour {
    public GameObject windowScore;
    private float speed = 20f;
    [Header("Desceleration"),Range(0,50)]
    public float d = 0f;
    private Camera cam;
    private Text rotationText;
    [HideInInspector]
    public int heroState = 0;

    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        rotationText = GameObject.Find("rotationText").GetComponent<Text>();
    }

    //void OnMouseOver()
    //{
    //    //If your mouse hovers over the GameObject with the script attached, output this message
    //   // Debug.Log("Mouse is over GameObject.");
    //    if (Input.GetMouseButtonDown(0) && heroState == 0)
    //    {
    //        heroState += 1;
    //        Debug.Log("left clicked!");
    //    }
    //}

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
    }

    void Update()
    {
            changeHeroState();
    }

    IEnumerator waitForSecond()
    {
        yield return new WaitForSeconds(.1f);
        if (Input.GetMouseButtonDown(0))
        {
            new WaitForSeconds(.1f);
            heroState = 2;
        }
    }

    private void changeHeroState()
    {
        if(heroState == 1)
        {
            StartCoroutine("waitForSecond");
            Quaternion tempRot = transform.rotation;
            Quaternion rot = transform.rotation;
            Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            transform.LookAt(mousePos, new Vector3(0f, 0f, -1f));
            rot.Set(rot.x, rot.y, transform.rotation.z, transform.rotation.w);
            transform.rotation = rot;
            int speedConvertTotrMin = (int)speed / 60;

            float rotSpeed = Quaternion.Angle(tempRot, transform.rotation);
            if (rotSpeed <= 1)
            {
                speed = (speed <= 0) ? 0f : speed - d;
            }
            else
            {
                speed += rotSpeed * 0.1f;
                if(speedConvertTotrMin > 30)
                {
                    speed = 30 * 60;
                }
            }
            //Debug.Log("valeur angle : " + rotSpeed);
            //Debug.Log("valeur angle Z : " + rot.z + ", valeur angle W : " + rot.w);
            //Debug.Log("sin  : " + Mathf.Sin(transform.rotation.z) + " cos : " + Mathf.Cos(transform.rotation.z));
            //float angle = transform.rotation.z;
            //Vector3 axis = Vector3.zero;
            //transform.rotation.ToAngleAxis(out angle, out axis);

           // Debug.Log("Euler angle : " + transform.rotation.eulerAngles);
            //Debug.Log("sin : " + sinAngle +", cos : " + cosAngle );
            rotationText.text = string.Format("vitesse rotation : {0} tr/min", speedConvertTotrMin);
        }
        else if(heroState == 2)
        {
            int speedConvertTotrMin = (int)speed / 60;
            ballScript ball = GameObject.FindGameObjectWithTag("ball").GetComponent<ballScript>();
            ball.transform.SetAsFirstSibling();
            ball.transform.position += ball.transform.up * speedConvertTotrMin * Time.deltaTime;
            cam.transform.position = new Vector3(ball.transform.position.x, ball.transform.position.y, cam.transform.position.z);

            if(speed > 0)
            {
                //desc += (d /100) * Time.deltaTime;
                speed = (speed <= 0) ? 0f : speed - d*10 * Time.deltaTime;
                if (!ball.isCollided) speed = 0;
            }
            else
            {
                heroState = 3;
            }
        }else if(heroState == 3)
        {
            ballScript ball = GameObject.FindGameObjectWithTag("ball").GetComponent<ballScript>();
            windowScore.SetActive(true);
            Text child = windowScore.GetComponentInChildren<Text>();
            if (ball.isCollided)
            {
                float coef = Vector3.Distance(cam.transform.position, transform.position) * 1.205f;
                child.text = "distance : " + (int)coef + " m";
            }
            else
            {
                child.text = "out !";
            }
        }

        
    }
}

