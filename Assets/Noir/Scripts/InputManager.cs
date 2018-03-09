using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	float accel = 0.0f;
    float temp = 0.0f;

    public GameObject AddCanvas;

    public GameObject ProfileCanvas;

	private MoneyManager money;
    private DisplayManager displayManager;

  public GameObject millionpop;

	// Use this for initialization
	void Start () {
		money = GetComponent<MoneyManager>();
        displayManager = GetComponent<DisplayManager>();
        	}
	
	// Update is called once per frame
	void Update () {
		
		accel = Input.acceleration.z;
        Vector3 acce = Input.acceleration;

        //Debug.Log(acce.magnitude);

        //TODO 以前のtempよりもある程度変化があれば
        if((acce.magnitude - temp) > 1.0f ){
            if(acce.magnitude > 2.0f){
          money.plus();
                //コインを飛ばす処理
                displayManager.Move(); 
            }
        }

        //配列01でとって，temp

        temp = acce.magnitude;

	
	}

  public void ProfOn()
  {
    ProfileCanvas.SetActive(true);
  }

  public void ProfOff()
  {
    ProfileCanvas.SetActive(false);
  }

  public void AddOn()
  {
    AddCanvas.SetActive(true);
  }
  public void AddOff()
  {
    AddCanvas.SetActive(false);
  }

  public void MillionPop()
  {
    millionpop.SetActive(true);
  }

}
