using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondEffectController : MonoBehaviour {


    public Material mat;
    private GameObject Net;
    CatcherScript Catch;
    float money, premoney, diff;

    float time;
    bool flag = true;
    float offSet = 0.0f;

	void Start () {
        Net = GameObject.Find("NCMBSettings");
        Catch = Net.GetComponent<CatcherScript>();
        premoney = 0.0f;


	}
	
	
	void Update () {
        
        Debug.Log(flag);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            flag = !flag;
        }

        if (flag)
        {
            money = Catch.amountmoney;
            diff = money - premoney;

            time += (Time.deltaTime / 2.0f);

            if (offSet > 1.0)
            {
                offSet = 0.0f;
            }
            if (Mathf.Abs(diff) >= 1.0)
            {
                offSet += Random.Range(0, 0.1f);

            }
            offSet += Time.deltaTime/2.0f;
            mat.SetFloat("_Step", offSet);
            premoney = money;

        }
        else
        {

            if (time > 1.0)
            {
                time = 0.0f;
            }
            //水面の高さの設定
            time += (Time.deltaTime / 2.0f);
            mat.SetFloat("_Step", time);
            //premoney = money;
        }
	}
}
