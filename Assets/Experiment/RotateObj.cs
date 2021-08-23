using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    Camera cam;
    GameObject camObj;
    public Vector3 rotVel;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        camObj = cam.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //polar += new Vector2(rotSpeed, 0);
        //camObj.transform.position = new Vector3(Mathf.Cos(polar.x)*Mathf.Sin(polar.y), Mathf.Cos(polar.y), Mathf.Sin(polar.x)*Mathf.Sin(polar.y)) * -1*r + new Vector3(0, camObj.transform.position.y, 0);
        //camObj.transform.eulerAngles = (polar + new Vector2(-Mathf.PI/2.0f, 0)) * -180f / Mathf.PI;
        camObj.transform.RotateAround(Vector3.zero, Vector3.up, rotVel.x);
        camObj.transform.RotateAround(Vector3.zero, Vector3.right, rotVel.y);
        camObj.transform.RotateAround(Vector3.zero, Vector3.back, rotVel.z);
    }
}
