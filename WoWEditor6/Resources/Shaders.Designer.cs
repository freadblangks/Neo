﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36323
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WoWEditor6.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Shaders {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Shaders() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WoWEditor6.Resources.Shaders", typeof(Shaders).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to cbuffer GlobalParamsBuffer : register(b0)
        ///{
        ///    float4 ambientLight;
        ///    float4 diffuseLight;
        ///    float4 fogColor;
        ///    // x -&gt; fogStart
        ///    // y -&gt; fotEnd
        ///    // z -&gt; farClip
        ///    float4 fogParams;
        ///};
        ///
        ///struct PixelInput
        ///{
        ///    float4 position : SV_Position;
        ///    float3 normal : NORMAL0;
        ///    float2 texCoord : TEXCOORD0;
        ///    float depth : TEXCOORD1;
        ///};
        ///
        ///float3 getDiffuseLight(float3 normal) {
        ///    float light = dot(normal, normalize(-float3(-1, 1, -1)));
        ///    if (light &lt; 0.0)
        ///        light = 0.0;
        ///    if (light &gt; 0.5)
        ///        light = 0.5 + (lig [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string M2Pixel {
            get {
                return ResourceManager.GetString("M2Pixel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to struct PixelInput
        ///{
        ///    float4 position : SV_Position;
        ///    float3 normal : NORMAL0;
        ///    float2 texCoord : TEXCOORD0;
        ///};
        ///
        ///float3 getDiffuseLight(float3 normal) {
        ///    float light = dot(normal, normalize(-float3(-1, 1, -1)));
        ///    if (light &lt; 0.0)
        ///        light = 0.0;
        ///    if (light &gt; 0.5)
        ///        light = 0.5 + (light - 0.5) * 0.65;
        ///
        ///    float3 diffuse = float3(0.7, 0.7, 0.7) * light;
        ///    diffuse += float3(0.3, 0.3, 0.3);
        ///    diffuse = saturate(diffuse);
        ///    return diffuse;
        ///}
        ///
        ///Texture2D baseTexture : register(t0);
        ///SamplerState baseS [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string M2PixelPortrait {
            get {
                return ResourceManager.GetString("M2PixelPortrait", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to cbuffer GlobalParams : register(b0)
        ///{
        ///    float4x4 matView;
        ///    float4x4 matProj;
        ///    float4 eyePosition;
        ///};
        ///
        ///cbuffer AnimationMatrices : register(b2)
        ///{
        ///    row_major float4x4 Bones[256];
        ///}
        ///
        ///cbuffer UvAnimation : register(b3)
        ///{
        ///    row_major float4x4 UvAnimation;
        ///}
        ///
        ///struct VertexInput
        ///{
        ///    float3 position : POSITION0;
        ///    float4 boneWeights : BLENDWEIGHT0;
        ///    int4 bones : BLENDINDEX0;
        ///    float3 normal : NORMAL0;
        ///    float2 texCoord : TEXCOORD0;
        ///    float2 texCoord2 : TEXCOORD1;
        ///
        ///    float4 mat0 : TEXCOORD2;
        ///    floa [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string M2VertexInstanced {
            get {
                return ResourceManager.GetString("M2VertexInstanced", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to cbuffer GlobalParams : register(b0)
        ///{
        ///    float4x4 matView;
        ///    float4x4 matProj;
        ///};
        ///
        ///cbuffer AnimationMatrices : register(b2)
        ///{
        ///    row_major float4x4 Bones[256];
        ///}
        ///
        ///cbuffer UvAnimation : register(b3)
        ///{
        ///    row_major float4x4 UvAnimation;
        ///}
        ///
        ///struct VertexInput
        ///{
        ///    float3 position : POSITION0;
        ///    float4 boneWeights : BLENDWEIGHT0;
        ///    int4 bones : BLENDINDEX0;
        ///    float3 normal : NORMAL0;
        ///    float2 texCoord : TEXCOORD0;
        ///    float2 texCoord2 : TEXCOORD1;
        ///};
        ///
        ///struct VertexOutput
        ///{
        ///    float4 position : SV_Posi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string M2VertexPortrait {
            get {
                return ResourceManager.GetString("M2VertexPortrait", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to cbuffer GlobalParamsBuffer : register(b0)
        ///{
        ///    float4 ambientLight;
        ///    float4 diffuseLight;
        ///    float4 fogColor;
        ///    // x -&gt; fogStart
        ///    // y -&gt; fotEnd
        ///    // z -&gt; farClip
        ///    float4 fogParams;
        ///};
        ///
        ///float4 main(float4 position : SV_Position, float depth : TEXCOORD0) : SV_Target{
        ///    clip(depth - (fogParams.y / fogParams.z));
        ///    return float4(fogColor.rgb, 1.0);
        ///}.
        /// </summary>
        internal static string MapLowPixel {
            get {
                return ResourceManager.GetString("MapLowPixel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to cbuffer GlobalParams : register(b0)
        ///{
        ///    float4x4 matView;
        ///    float4x4 matProj;
        ///    float4 eyePosition;
        ///};
        ///
        ///struct VSInput
        ///{
        ///    float3 position : POSITION0;
        ///};
        ///
        ///struct VSOutput
        ///{
        ///    float4 position : SV_Position;
        ///    float depth : TEXCOORD0;
        ///};
        ///
        ///VSOutput main(VSInput input) {
        ///    VSOutput output = (VSOutput) 0;
        ///    output.position = float4(input.position, 1.0);
        ///    output.position = mul(output.position, matView);
        ///    output.position = mul(output.position, matProj);
        ///
        ///    output.depth = output.position.z / output. [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MapLowVertex {
            get {
                return ResourceManager.GetString("MapLowVertex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Texture2D skyTexture : register(t0);
        ///SamplerState skySampler : register(s0);
        ///
        ///struct PSInput
        ///{
        ///    float4 position : SV_Position;
        ///    float2 texCoord : TEXCOORD0;
        ///};
        ///
        ///float4 main(PSInput input) : SV_Target {
        ///    return skyTexture.Sample(skySampler, input.texCoord);
        ///}.
        /// </summary>
        internal static string SkyPixel {
            get {
                return ResourceManager.GetString("SkyPixel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to cbuffer GlobalBuffer : register(b0)
        ///{
        ///    float4x4 matView;
        ///    float4x4 matProj;
        ///};
        ///
        ///cbuffer MatrixBuffer : register(b1)
        ///{
        ///    float4 translation;
        ///};
        ///
        ///struct VertexInput
        ///{
        ///    float3 position : POSITION0;
        ///    float2 texCoord : TEXCOORD0;
        ///};
        ///
        ///struct VertexOutput
        ///{
        ///    float4 position : SV_Position;
        ///    float2 texCoord : TEXCOORD0;
        ///};
        ///
        ///VertexOutput main(VertexInput input) {
        ///    float4 position = float4(input.position + translation.xyz, 1.0);
        ///    position = mul(position, matView);
        ///    position = mul(position, mat [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SkyVertex {
            get {
                return ResourceManager.GetString("SkyVertex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to struct PixelInput
        ///{
        ///    float4 position : SV_Position;
        ///    float3 normal : NORMAL0;
        ///    float2 texCoord : TEXCOORD0;
        ///    float2 texCoordAlpha : TEXCOORD1;
        ///    float4 color : COLOR0;
        ///    float depth : TEXCOORD2;
        ///    float3 worldPosition : TEXCOORD3;
        ///};
        ///
        ///SamplerState alphaSampler : register(s1);
        ///SamplerState colorSampler : register(s0);
        ///
        ///Texture2D alphaTexture : register(t0);
        ///Texture2D texture0 : register(t1);
        ///Texture2D texture1 : register(t2);
        ///Texture2D texture2 : register(t3);
        ///Texture2D texture3 : register(t4) [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TerrainPixel {
            get {
                return ResourceManager.GetString("TerrainPixel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to struct PixelInput
        ///{
        ///    float4 position : SV_Position;
        ///    float3 normal : NORMAL0;
        ///    float2 texCoord : TEXCOORD0;
        ///    float2 texCoordAlpha : TEXCOORD1;
        ///    float4 color : COLOR0;
        ///    float depth : TEXCOORD2;
        ///    float3 worldPosition : TEXCOORD3;
        ///};
        ///
        ///SamplerState alphaSampler : register(s1);
        ///SamplerState colorSampler : register(s0);
        ///
        ///Texture2D alphaTexture : register(t0);
        ///Texture2D texture0 : register(t1);
        ///Texture2D texture1 : register(t2);
        ///Texture2D texture2 : register(t3);
        ///Texture2D texture3 : register(t4) [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TerrainPixelNew {
            get {
                return ResourceManager.GetString("TerrainPixelNew", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to struct VertexInput
        ///{
        ///    float3 position : POSITION0;
        ///    float3 normal : NORMAL0;
        ///    float2 texCoord : TEXCOORD0;
        ///    float2 texCoordAlpha : TEXCOORD1;
        ///    float4 color : COLOR0;
        ///};
        ///
        ///struct VertexOutput
        ///{
        ///    float4 position : SV_Position;
        ///    float3 normal : NORMAL0;
        ///    float2 texCoord : TEXCOORD0;
        ///    float2 texCoordAlpha : TEXCOORD1;
        ///    float4 color : COLOR0;
        ///    float depth : TEXCOORD2;
        ///    float3 worldPosition : TEXCOORD3;
        ///};
        ///
        ///cbuffer GlobalParams : register(b0)
        ///{
        ///    float4x4 matView;
        ///    float4x4 matProj;
        ///    float4  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TerrainVertex {
            get {
                return ResourceManager.GetString("TerrainVertex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to struct VertexInput
        ///{
        ///    float2 position : POSITION0;
        ///    float2 texCoord : TEXCOORD0;
        ///};
        ///
        ///struct VertexOutput
        ///{
        ///    float4 position : SV_Position;
        ///    float2 texCoord : TEXCOORD0;
        ///};
        ///
        ///VertexOutput main(VertexInput input) {
        ///    VertexOutput output = (VertexOutput) 0;
        ///    output.position = float4(input.position, 0, 1);
        ///    output.texCoord = input.texCoord;
        ///
        ///    return output;
        ///}.
        /// </summary>
        internal static string TexturedQuadVertex {
            get {
                return ResourceManager.GetString("TexturedQuadVertex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to struct PixelInput
        ///{
        ///    float4 position : SV_Position;
        ///    float2 texCoord : TEXCOORD0;
        ///};
        ///
        ///Texture2D quadTexture : register(t0);
        ///SamplerState quadSampler : register(s0);
        ///
        ///float4 main(PixelInput input) : SV_Target {
        ///    return quadTexture.Sample(quadSampler, input.texCoord);
        ///}.
        /// </summary>
        internal static string TextureQuadPixel {
            get {
                return ResourceManager.GetString("TextureQuadPixel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to cbuffer GlobalParamsBuffer : register(b0)
        ///{
        ///    float4 ambientLight;
        ///    float4 diffuseLight;
        ///    float4 fogColor;
        ///    // x -&gt; fogStart
        ///    // y -&gt; fotEnd
        ///    // z -&gt; farClip
        ///    float4 fogParams;
        ///};
        ///
        ///Texture2D batchTexture : register(t0);
        ///SamplerState batchSampler : register(s0);
        ///
        ///struct PSInput
        ///{
        ///    float4 position : SV_Position;
        ///    float3 normal : NORMAL0;
        ///    float2 texCoord : TEXCOORD0;
        ///    float depth : TEXCOORD1;
        ///    float4 color : COLOR0;
        ///};
        ///
        ///float3 getDiffuseLight(float3 normal) {
        ///    float light = dot(normal,  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string WmoPixel {
            get {
                return ResourceManager.GetString("WmoPixel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to cbuffer MatrixBuffer : register(b0)
        ///{
        ///    float4x4 matView;
        ///    float4x4 matProj;
        ///    float4 eyePosition;
        ///};
        ///
        ///cbuffer InstanceBuffer : register(b1)
        ///{
        ///    float4x4 matInstance;
        ///};
        ///
        ///struct VSInput
        ///{
        ///    float3 position : POSITION0;
        ///    float3 normal : NORMAL0;
        ///    float2 texCoord : TEXCOORD0;
        ///    float4 color : COLOR0;
        ///};
        ///
        ///struct VSOutput
        ///{
        ///    float4 position : SV_Position;
        ///    float3 normal : NORMAL0;
        ///    float2 texCoord : TEXCOORD0;
        ///    float depth : TEXCOORD1;
        ///    float4 color : COLOR0;
        ///};
        ///
        ///VSOutput main(VSInput in [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string WmoVertex {
            get {
                return ResourceManager.GetString("WmoVertex", resourceCulture);
            }
        }
    }
}
