using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace sakana
{
    public class ThresholdManager : MonoBehaviour
    {
       
        public int mode = 0;
        public float time = 0.0f;
	    void Start () {
		
	    }
	
	
	    void Update () {
            time += Time.deltaTime;

            if (time >= 0.0 && time < 5.0f)
            {
                mode = 0;
            }else if(time >= 5.0f && time < 10.0f){
                mode = 1; 
            }else if(time >= 10.0f && time < 15.0f){
                mode = 2;
            }else if(time >= 15.0f){
                time = 0.0f;
                mode = 0;
            }
	    }
    }
}