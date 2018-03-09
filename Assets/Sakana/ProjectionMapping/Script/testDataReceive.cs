using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testDataReceive : MonoBehaviour {

	// Use this for initialization
    public GameObject Net;
    CatcherScript Catch;
	void Start () {
        Catch = Net.GetComponent<CatcherScript>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
