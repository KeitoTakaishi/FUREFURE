using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour {
    public Material mat;
    static float colNum = 0.0f;
	void Start () {
		
	}
	
	
	void Update () {
        gameObject.transform.position += new Vector3(0.0f, 0.3f, 0.0f);
        if(transform.position.y > 4){
            DestroyImmediate(gameObject);
            colNum += 1.0f;
            Debug.Log(colNum);
            mat.SetFloat("_colNum", colNum);
        }

	}
}
