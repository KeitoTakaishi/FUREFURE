Shader "Custom/EffectStatrt" {
	Properties {
        [HDR]_Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _alpha("Alpha", Range(0, 1))  = 1.0
        _MoneyValue("MoneyValue",Range(0, 1.0)) = 0.5
        _Step("Step", float) = 0.0
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


            fixed4 _Color;
            float _alpha;
            float _MoneyValue;
            float _Step;


            v2f vert (appdata_full v) {
                v2f o;
                o.uv = v.texcoord;
                float3 LocalPos = mul(unity_WorldToObject, v.vertex).xyz;

                if(o.uv.y < 0.05 && o.uv.x < sin(_Time.w * 1)){
                   o.col = float4(1.0, 1.0, 1.0, 0.5);
                   o.col.w = 1.0;
                }else if(o.uv.y > 0.95 && o.uv.x < sin(_Time.w * -1.0)){
                   o.col = float4(1.0, 1.0, 1.0, 0.5);
                   o.col.w = 1.0;
                }else if(o.uv.x < 0.05 && o.uv.y < sin(_Time.w )){
                   o.col = float4(1.0, 1.0, 1.0, 0.5);
                   o.col.w = 1.0;
                }else if(o.uv.x > 0.95 && o.uv.y < sin(_Time.w * -1.0)){
                   o.col = float4(1.0, 1.0, 1.0, 0.5);
                   o.col.w = 1.0;
                }else{
                   o.col = float4(0.0, 0.0, 0.0, 0.5);
                   o.col.w = 0.5;
                }
                
                o.pos = UnityObjectToClipPos(v.vertex);

                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                
                float4 col = i.col * _Color;
               
                return col;
            } 
              ENDCG

        }
    }
}