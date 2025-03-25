Shader "Custom/StripedGreenMaterial"
{
    Properties
    {
        _Color1 ("Dark Green", Color) = (0.0, 0.4, 0.0, 1.0)
        _Color2 ("Light Green", Color) = (0.5, 1.0, 0.5, 1.0)
        _Scale ("Stripe Scale", Float) = 10.0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata_t
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            fixed4 _Color1;
            fixed4 _Color2;
            float _Scale;

            v2f vert (appdata_t v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv * _Scale;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float stripe = step(0.5, frac(i.uv.y)); // สร้างลายสลับ
                return lerp(_Color1, _Color2, stripe);
            }
            ENDCG
        }
    }
}

