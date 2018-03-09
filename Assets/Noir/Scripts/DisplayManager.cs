using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayManager : MonoBehaviour
{

  MoneyManager money;
  Text amountText;
  Text addText;

  public GameObject coin;


  void Awake()
  {

  }

  // Use this for initialization
  void Start()
  {
    money = GetComponent<MoneyManager>();
    amountText = GameObject.Find("AmountText").GetComponent<Text>();
    addText = GameObject.Find("addText").GetComponent<Text>();


  }

  // Update is called once per frame
  void Update()
  {

    amountText.text = "¥" + money.TipMoney.ToString();
    addText.text = "¥" + money.AddMoney.ToString();

        ////速度を制御
        //if (coin.gameObject.transform.position.y > 30){
        //    rb.velocity = Vector3.zero;
        //    coin.gameObject.transform.position = new Vector3(0, -5, 15);
        //}
  }


  public void Move()
  {

    //プレハブからリソースロード
    //GameObject coin = (GameObject)Resources.Load("Prefabs/Coin");
    // プレハブからインスタンスを生成
    GameObject coin2 = Instantiate(coin, coin.gameObject.transform.position, Quaternion.identity) as GameObject;
    coin2.gameObject.GetComponent<Coin>().Move();

    //coin = Instantiate(coin, new Vector3(0, -5, 15), coin.gameObject.transform.rotation) as GameObject;
    //Coinオブジェクトを取得

    //coinを飛ばす

    //coin.gameObject.transform.Translate(Vector3.up * 2);

    //rb.velocity = new Vector3(0, 20, 0);

    //GameObject original = GameObject.Find("Coin");
    //GameObject copied = Object.Instantiate(original) as GameObject;
  }
}
