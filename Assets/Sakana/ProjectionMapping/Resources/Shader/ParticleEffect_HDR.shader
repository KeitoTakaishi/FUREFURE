Shader "Custom/ParticleEffect_HDR" {
	Properties {
        [HDR]_Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
        _alpha("Alpha", Range(0, 1))  = 1.0
        _MoneyValue("MoneyValue",Range(0, 1.0)) = 0.5
        _Step("Step", float) = 0.0
    }
    SubShader {
        
        Tags { 
            "Queue" = "Transparent"            
            "RenderType" = "TransparentCutout"
            "IgnoreProjector"="True" 
            "RenderType"="Transparent"
         }
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


            v2f vert (appdata_full v) {
                v2f o;
                o.uv = v.texcoord;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.col = float4 (1.0,1.0,1.0,1.0);

                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                

                fixed4 col = tex2D(_MainTex, i.uv);
                if(col.r == 0.0){
                    discard;
                }
                return col*_Color;
            } 
              ENDCG

        }
    }
}