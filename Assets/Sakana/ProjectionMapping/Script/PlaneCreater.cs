using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
effect tree
making plane and left it up
*/
public class PlaneCreater : MonoBehaviour {

    public GameObject Effect3Obj;

    private GameObject Net;
    CatcherScript Catch;
    float money, premoney, diff;
    //-----
    float time;
    //-----
    bool flag = true;
	void Start () {
        Net = GameObject.Find("NCMBSettings");
        Catch = Net.GetComponent<CatcherScript>();
        premoney = 0.0f;

        time = 0.0f;
	}
	
	
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space)){
            flag = !flag;
        }

        if (flag)
        {
            money = Catch.amountmoney;
            diff = money - premoney;
            Debug.Log(diff);
            diff += Random.Range(0, 3);

            if (Mathf.Abs(diff) >= Random.Range(0, 13))
            {
                Instantiate(Effect3Obj, transform.position, Quaternion.identity);
            }
            premoney = money;
            diff = 0.0f;
        }else{
            time += Random.Range(0, 0.05f);
            if (time > Random.Range(0.2f, 0.5f))
            {
                Instantiate(Effect3Obj, transform.position, Quaternion.identity);
                time = 0.0f;
            }
        }
	}
}
