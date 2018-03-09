using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using NCMB;

public class MoneyManager : MonoBehaviour
{
    private int tipMoney;
  public int TipMoney { set { tipMoney = value; } get { return tipMoney; } }

  private int addMoney;
  public int AddMoney { set { addMoney = value; } get { return addMoney; } }


  // Use this for initialization
  void Start(){
    tipMoney = 0;
    addMoney = 10;
  }

  // Update is called once per frame
  void Update(){

  }

  public void SendDate(){
    NCMBObject money = new NCMBObject("Money");
    money["amount"] = addMoney;
    money["user"] = "pitcher";

    money.SaveAsync();
    }

    public void plus(){
        SendDate();
        TipMoney += addMoney;
    }

}
