Shader "Custom/Transform Verte" {
    Properties {
        _Metallic ("Metallic", Range(0,1)) = 0.0
        _Length ("Length", float) = 0.0
    }
	SubShader {
        Tags { "RenderType" = "Opaque" }
        CGPROGRAM
        //#pragma surface surf Lambert vertex:vert
        #pragma surface surf Standard Lambert vertex:vert

        float _Length;

        struct Input {
            float4 color : COLOR;
        };
        void vert (inout appdata_full v) {
            v.vertex.x += (_Length + .1) * v.normal.x * sin(v.vertex.y * 3.14 * 16 * _Time.x * 5.0f);
            v.vertex.z += (_Length + .1) * v.normal.z * sin(v.vertex.y * 3.14 * 16 * _Time.x * 5.0f);
        }

        float _Metallic;

        void surf (Input IN, inout SurfaceOutputStandard o) {
            o.Albedo = half3(1, 1, 1);
            o.Metallic = _Metallic; 
        }
		ENDCG
	}
	FallBack "Diffuse"
}
