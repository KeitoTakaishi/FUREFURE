using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MillionPopFalse : MonoBehaviour
{

  // Use this for initialization
  void Start()
  {

  }

  private void OnEnable()
  {
    Invoke("Falser", 2.0f);
  }

  // Update is called once per frame
  void Update()
  {

  }

  void Falser()
  {
    this.gameObject.SetActive(false);
  }
}
