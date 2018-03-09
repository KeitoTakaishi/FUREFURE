using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    private float time;
	void Start () {
		
	}
	
	void Update () {
        time += Time.deltaTime;
        transform.eulerAngles = new Vector3(time * 30.0f, time * 30.0f, time * 30.0f);
	}
}
