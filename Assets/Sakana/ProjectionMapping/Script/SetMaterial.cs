using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sakana
{
    public class SetMaterial : MonoBehaviour
    {
        public Material mat1, mat2, mat3;
        float time;
        MeshRenderer mr;

        //effect管理object
        public GameObject manager;
        ThresholdManager threshold;

        private void Awake()
        {
            manager = GameObject.Find("Threshold");
            threshold = manager.GetComponent<ThresholdManager>();
        }
        void Start()
        {
            mr = GetComponent<MeshRenderer>();
            mr.material = mat1;
        }


        void Update()
        {
            if (threshold.mode == 0)
            {
                mr.material = mat1;
            }else if(threshold.mode == 1){
                mr.material = mat2;
            }else if (threshold.mode == 2)
            {
                mr.material = mat3;
            }


        }
    }
}
