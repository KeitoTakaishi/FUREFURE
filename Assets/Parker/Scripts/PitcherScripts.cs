using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using NCMB;

public class PitcherScripts : MonoBehaviour
{

  int add = 0;

  int myamount = 0;

  public Text text;


  // Use this for initialization
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void AddOne()
  {
    add = 1;
    SendData();
    LocalAmount();
  }


  public void AddTen()
  {
    add = 10;
    SendData();
    LocalAmount();
  }


  public void AddHundred()
  {
    add = 100;
    SendData();
    LocalAmount();
  }

  void SendData()
  {

    NCMBObject money = new NCMBObject("Money");
    money["amount"] = add;
    money["user"] = "pitcher";

    money.SaveAsync();
  }

  void LocalAmount()
  {
    myamount += add;
    text.text = myamount.ToString() + "円";
  }

  public void DisplayAmount()
  {
    NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("Money");
    query.WhereEqualTo("user", "pitcher");
    query.FindAsync((List<NCMBObject> objList, NCMBException e) =>
    {

      int amount = 0;

      if (e == null)
      {
        if (objList.Count == 0)
        {

        }
        else
        {

          for (int i = 0; i < objList.Count; i++)
          {

            amount += System.Convert.ToInt32(objList[i]["amount"]);

          }

          Debug.Log(amount);
        }
      }
    });
  }
}
