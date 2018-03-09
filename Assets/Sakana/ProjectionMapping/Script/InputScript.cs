using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    effect1について
    particleの処理のまとめ、shaderへのお金の値の送信
*/

namespace sakana
{
    public class InputScript : MonoBehaviour
    {
        float count = 0.0f;
        public Material mat;
        ParticleSystem ps;
        float time;



        private void Awake()
        {
            ps = GetComponent<ParticleSystem>();

        }
        void Start()
        {

        }
        void Update()
        {
            time += Time.deltaTime;
            if (Input.GetMouseButton(0))
            {
                ps.Play();

                if (count > 1.0f)
                {
                    ps.Play();
                    count = 0.0f;
                }
                count += 0.01f;
                mat.SetFloat("_Step", count);


            }
        }
    }
}
