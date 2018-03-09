using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title2Checker : MonoBehaviour {

	// Use this for initialization
	void Start () {
    Invoke("ToTitle", 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  void ToTitle()
  {
    SceneManager.LoadScene("AmountCheck");
  }
}
