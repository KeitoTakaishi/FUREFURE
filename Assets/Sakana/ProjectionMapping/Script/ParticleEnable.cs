using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
1つ目のparticleをenableにする
*/
namespace sakana
{

    public class ParticleEnable : MonoBehaviour
    {
        public GameObject childObj;
        public GameObject DestroyObj;
        float time;
        void Start()
        {
            childObj.SetActive(false);

        }


        void Update()
        {
            childObj.SetActive(true);
            DestroyImmediate(DestroyObj);
        }
    }

}
