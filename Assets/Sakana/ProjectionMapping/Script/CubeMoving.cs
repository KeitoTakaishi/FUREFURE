using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoving : MonoBehaviour {

    Vector3[] vel;
    Vector3 v = new Vector3(0, 0, 0);
    int FrameCount = 0;
	void Start () {
        vel = new Vector3[]
        {
            new Vector3(-1/2f, 0f, 0f),
            new Vector3(1/2f, 0f, 0f),
            new Vector3(0f, 0f, 1/2f),
            new Vector3(0f, 0f, -1/2f),
            new Vector3(0f, 1/2f, 0f),
            new Vector3(0f, -1/2f, 0f),

        };
	}
	
	
	void Update () {


        if (FrameCount % 20 == 0)
        {
            int r = Random.Range(0, 6);
            v = vel[r];

            //gameObject.transform.position += v;
        }else if(FrameCount % 50 == 0 ){
            //gameObject.transform.position -= v;   
        }

        FrameCount++;
	}
}
