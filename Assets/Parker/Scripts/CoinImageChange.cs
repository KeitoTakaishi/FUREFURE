using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinImageChange : MonoBehaviour {

  public Sprite[] img;

  MoneyManager manager;
  SpriteRenderer mat;

	// Use this for initialization
	void Start () {
    manager = GameObject.Find("Manager").GetComponent<MoneyManager>();
    mat = GetComponent<SpriteRenderer>();

	}
	
	// Update is called once per frame
	void Update () {
    if(manager.AddMoney == 1)
    {
      mat.sprite = img[0];
    }
    if (manager.AddMoney == 5)
    {
      mat.sprite = img[1];
    }
    if (manager.AddMoney == 10)
    {
      mat.sprite = img[2];
    }
    if (manager.AddMoney == 50)
    {
      mat.sprite = img[3];
    }
    if (manager.AddMoney == 100)
    {
      mat.sprite = img[4];
    }
	}
}
