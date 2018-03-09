using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMoneyChange : MonoBehaviour {

  public int add;

  public void OnClick()
  {
    MoneyManager manager = GameObject.Find("Manager").GetComponent<MoneyManager>();

    manager.AddMoney = add;
  }
}
