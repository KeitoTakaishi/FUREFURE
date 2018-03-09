using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using NCMB;

public class CatcherScript : MonoBehaviour
{
  public int amountmoney;
  //public int Amountmoney { set; get; }
  public int localamount;

  int beforecount = 0;

  // Use this for initialization
  void Start()
  {
    NCMBObject obj = new NCMBObject("Money");
    obj.DeleteAsync((NCMBException e) => {
      if (e != null)
      {
        Debug.Log("データ削除できず");//エラー処理
      }
      else
      {
        Debug.Log("データ削除");//成功時の処理
      }
    });
    /*
    ArrayList array = new ArrayList();
    array.Add("pitcher");
    obj.RemoveRangeFromList("user", array);
    obj.SaveAsync();
    */

    amountmoney = 0;
    localamount = 0;
    InvokeRepeating("CatchData", 1.0f, 1.0f);
  }

  // Update is called once per frame
  void Update()
  {
    Debug.Log("catcher:" + amountmoney);
  }

  void CatchData()
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
          beforecount = 0;
        }
        else
        {
          for (int i = 0; i < objList.Count; i++)
          {

            amount += System.Convert.ToInt32(objList[i]["amount"]);

          }

          amountmoney = amount;
        }
      }
    });
  }
}
