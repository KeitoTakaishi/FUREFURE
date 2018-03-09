using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCreaterSub : MonoBehaviour
{

    public GameObject Effect3Obj;
    float time;


    void Start()
    {
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > .5f)
        {
            Instantiate(Effect3Obj, transform.position, Quaternion.identity);
            time = 0.0f;
        }
    }
}
