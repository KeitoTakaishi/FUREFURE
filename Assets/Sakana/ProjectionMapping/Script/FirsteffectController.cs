using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirsteffectController : MonoBehaviour {
    public Material mat;
    float value = 0.0f;
    //--
    private GameObject Net;
    CatcherScript Catch;
    float money, premoney, diff;
    //-----
    bool flag = true;
    float time;

	void Start () {
        Net = GameObject.Find("NCMBSettings");
        Catch = Net.GetComponent<CatcherScript>();
        premoney = 0.0f;
        time = 0.0f;
	}


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            flag = !flag;
        }

        if (flag)
        {   

            money = Catch.amountmoney;
            diff = money - premoney;

            if (Mathf.Abs(money - premoney) >= 5)
            {
                value = Random.Range(0.1f, 0.5f);
                mat.SetFloat("_Length", value);
            }
        }else{
            time += Time.deltaTime;
            if (time > Random.Range(0.3f,0.5f))
            {
                value = Random.Range(0.1f, 0.7f);
                mat.SetFloat("_Length", value);
            }
             

        }
    


	}
}
