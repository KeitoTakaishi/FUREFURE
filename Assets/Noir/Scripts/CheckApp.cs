using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckApp : MonoBehaviour {

  public GameObject pop;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  public void PopOn()
  {
    pop.SetActive(true);
  }

  public void PopOff()
  {
    pop.SetActive(false);
  }
}
