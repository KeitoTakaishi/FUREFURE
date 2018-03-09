Shader "Custom/EffectThree" {
	Properties {
        [HDR]_Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
        _alpha("Alpha", Range(0, 1))  = 1.0
        __MoneyValue("MoneyValue",Range(0, 1.0)) = 0.0
        _Step("Step", float) = 0.0
        _colNum("colNum", float) = 0.0
    }
    SubShader {
        
        Tags { "RenderType" = "Transparent" "Queue"="Transparent" }
        Blend SrcAlpha OneMinusSrcAlpha

        Cull Off
        //ZWrite Off
        Pass {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma target 3.0
            #include "UnityCg.cginc"

            sampler2D _MainTex;

            struct v2f {
                float4 pos : SV_POSITION;
                float2 uv : TEXCOORD0;
                float4 col : COLOR;
            };

            half _Glossiness;
            half _Metallic;
            fixed4 _Color;
            float _alpha;
            float _MoneyValue;
            float _Step;
            int _colNum;



            v2f vert (appdata_full v) {
                v2f o;
                o.uv = v.texcoord;
                float3 LocalPos = mul(unity_WorldToObject, v.vertex).xyz;


                if( fmod(_colNum, 2.0) == 0 ){
                    o.col = float4(1.0, 1.0, 1.0, 1.0) * _Color;
                    o.col.w = 0.1;
                }else{
                    o.col = float4(0.0, 0.0, 0.0, 1.0);
                    o.col.w = 0.5;
                }

                //輪郭
               
                if(o.uv.y > 0.0 && o.uv.y < 0.05){
                   o.col = float4(0.0, 0.0, 0.0, 1.0);
                   o.col.w = 1.0;
                }else if(o.uv.y < 1.0 && o.uv.y > 0.95){
                   o.col = float4(0.0, 0.0, 0.0, 1.0);
                   o.col.w = 1.0;
                }else if(o.uv.x > 0.0 && o.uv.x < 0.05){
                   o.col = float4(0.0, 0.0, 0.0, 0.0);
                   o.col.w = 1.0;
                }else if(o.uv.x < 1.0 && o.uv.x > 0.95){
                   o.col = float4(0.0, 0.0, 0.0, 0.0);
                   o.col.w = 1.0;
                }
                o.pos = UnityObjectToClipPos(v.vertex);

                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                
                //float4 col = i.col * _Color;
               float4 col = i.col;
                return col;
            } 
              ENDCG

        }
    }
}
