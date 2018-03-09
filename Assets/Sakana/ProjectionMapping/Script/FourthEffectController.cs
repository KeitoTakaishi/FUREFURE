using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthEffectController : MonoBehaviour {

    public GameObject cube;
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Instantiate(cube, new Vector3(-1.5f + 1.5f * k, 0.5f + 1.5f * i, -1.5f + 1.5f * j), Quaternion.identity);
                }
            }
        }
    }
	
	
	void Update () {
		
	}
}
