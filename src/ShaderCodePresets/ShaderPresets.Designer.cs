﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zene.Graphics {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ShaderPresets {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ShaderPresets() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Zene.Graphics.ShaderCodePresets.ShaderPresets", typeof(ShaderPresets).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 430 core
        ///
        ///layout(location = 0) out vec4 colour;
        ///
        ///in vec4 pos_Colour;
        ///in vec2 tex_Coords;
        ///
        ///uniform int colourType;
        ///uniform vec4 uColour;
        ///uniform sampler2D uTextureSlot;
        ///
        ///void main()
        ///{
        ///	switch (colourType)
        ///	{
        ///		case 1:
        ///			colour = uColour;
        ///			break;
        ///
        ///		case 2:
        ///			colour = pos_Colour;
        ///			break;
        ///
        ///		case 3:
        ///			colour = texture(uTextureSlot, tex_Coords);
        ///			break;
        ///
        ///		default:
        ///			colour = vec4(1.0, 1.0, 1.0, 1.0);
        ///			break;
        ///	}
        ///}.
        /// </summary>
        public static string BasicFragment {
            get {
                return ResourceManager.GetString("BasicFragment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 330 core
        ///
        ///layout(location = locations.vertex) in vec3 vPosition;
        ///layout(location = locations.colour) in vec4 colour;
        ///layout(location = locations.texture) in vec2 texCoord;
        ///
        ///out vec4 pos_Colour;
        ///out vec2 tex_Coords;
        ///
        ///uniform mat4 matrix;
        ///
        ///void main()
        ///{
        ///	pos_Colour = colour;
        ///
        ///	tex_Coords = texCoord;
        ///
        ///	gl_Position = matrix * vec4(vPosition, 1);
        ///}.
        /// </summary>
        public static string BasicVertex {
            get {
                return ResourceManager.GetString("BasicVertex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 430 core
        ///
        ///layout(location = 0) out vec4 colour;
        ///
        ///in vec4 pos_Colour;
        ///in vec2 tex_Coords;
        ///
        ///uniform int colourType;
        ///uniform vec4 uColour;
        ///uniform vec4 uBorderColour;
        ///uniform sampler2D uTextureSlot;
        ///
        ///uniform float outerRadius;
        ///uniform float halfBW;
        ///uniform vec2 borderCrossOver;
        ///uniform vec2 aspect;
        ///uniform vec2 innerDMinusR;
        ///uniform float radius;
        ///uniform float rValue;
        ///
        ///float squaredLength(vec2 v)
        ///{
        ///	return (v.x * v.x) + (v.y * v.y);
        ///}
        ///
        ///void insideBorders()
        ///{
        ///	switch (colourT [rest of string was truncated]&quot;;.
        /// </summary>
        public static string BorderFrag {
            get {
                return ResourceManager.GetString("BorderFrag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 330 core
        ///
        ///layout(location = locations.vertex) in vec3 vPosition;
        ///layout(location = locations.colour) in vec4 colour;
        ///layout(location = locations.texture) in vec2 texCoord;
        ///
        ///out vec4 pos_Colour;
        ///out vec2 tex_Coords;
        ///
        ///uniform mat4 matrix;
        ///uniform vec2 size;
        ///
        ///void main()
        ///{
        ///    pos_Colour = colour;
        ///
        ///    tex_Coords = ((texCoord - 0.5) * size) + 0.5;
        ///    
        ///	gl_Position = matrix * vec4(vPosition, 1);
        ///}.
        /// </summary>
        public static string BorderVert {
            get {
                return ResourceManager.GetString("BorderVert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 430 core
        ///
        ///layout(location = 0) out vec4 colour;
        ///
        ///in vec4 pos_Colour;
        ///in vec2 tex_Coords;
        ///in vec2 pos;
        ///
        ///uniform int colourType;
        ///uniform vec4 uColour;
        ///uniform vec4 uBorderColour;
        ///uniform sampler2D uTextureSlot;
        ///
        ///uniform float minRadius;
        ///uniform float radius;
        ///
        ///void main()
        ///{
        ///	float len = (pos.x * pos.x) + (pos.y * pos.y);
        ///
        ///	// Outside main circle
        ///	if (len &gt; radius) { discard; }
        ///	// Inside mini circle
        ///	if (len &gt; minRadius)
        ///	{
        ///		colour = uBorderColour;
        ///		return;
        ///	}
        ///
        ///	switch ( [rest of string was truncated]&quot;;.
        /// </summary>
        public static string CircleFrag {
            get {
                return ResourceManager.GetString("CircleFrag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 330 core
        ///
        ///layout(location = locations.vertex) in vec3 vPosition;
        ///layout(location = locations.colour) in vec4 colour;
        ///layout(location = locations.texture) in vec2 texCoord;
        ///
        ///out vec4 pos_Colour;
        ///out vec2 tex_Coords;
        ///out vec2 pos;
        ///
        ///uniform mat4 matrix;
        ///uniform vec2 size;
        ///uniform vec2 c_off;
        ///
        ///void main()
        ///{
        ///    pos_Colour = colour;
        ///    tex_Coords = texCoord;
        ///
        ///    pos = (texCoord - c_off) * size;
        ///    
        ///	gl_Position = matrix * vec4(vPosition, 1);
        ///}.
        /// </summary>
        public static string CircleVert {
            get {
                return ResourceManager.GetString("CircleVert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 330 core
        ///
        ///void main()
        ///{
        ///    //gl_FragDepth = gl_FragCoord.z;
        ///}.
        /// </summary>
        public static string DepthMapFragment {
            get {
                return ResourceManager.GetString("DepthMapFragment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 330 core
        ///
        ///layout(location = locations.vertex) in vec3 vPosition;
        ///
        ///uniform mat4 matrix;
        ///
        ///uniform float depthOffset;
        ///
        ///void main()
        ///{
        ///	vec4 pos = (matrix) * vec4(vPosition, 1.0);
        ///
        ///	pos.z += depthOffset;
        ///
        ///	gl_Position = pos;
        ///}.
        /// </summary>
        public static string DepthMapVertex {
            get {
                return ResourceManager.GetString("DepthMapVertex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 430 core
        ///
        ///layout(location = 0) out vec4 colour;
        ///
        ///in vec4 pos_Colour;
        ///in vec2 tex_Coords;
        ///in vec2 normal_Coords;
        ///in vec3 normal;
        ///in mat3 TBN;
        ///in vec3 fragPos;
        ///in vec4 lightSpacePos;
        ///
        ///in vec2 tex_ambCoords;
        ///in vec3 pos_ambColour;
        ///in vec2 tex_specCoords;
        ///in vec3 pos_specColour;
        ///
        ///uniform bool normalMapping;
        ///uniform sampler2D uNormalMap;
        ///
        ///uniform int colourType;
        ///uniform vec4 uColour;
        ///uniform sampler2D uTextureSlot;
        ///
        ///struct Material
        ///{
        ///	int DiffuseLightSource;
        ///	vec3 DiffuseLight [rest of string was truncated]&quot;;.
        /// </summary>
        public static string LightingFragment {
            get {
                return ResourceManager.GetString("LightingFragment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 330 core
        ///
        ///layout(location = locations.vertex) in vec3 vPosition;
        ///layout(location = locations.colour) in vec4 colour;
        ///layout(location = locations.texture) in vec2 texCoord;
        ///layout(location = locations.normal) in vec3 vNormal;
        ///
        ///layout(location = 6) in vec3 ambientLight;
        ///layout(location = 7) in vec2 ambientTexture;
        ///layout(location = 8) in vec3 specularLight;
        ///layout(location = 9) in vec2 specularTexture;
        ///
        ///layout(location = locations.norm_tex) in vec2 normalTexCoord;
        ///layout(location = locat [rest of string was truncated]&quot;;.
        /// </summary>
        public static string LightingVertex {
            get {
                return ResourceManager.GetString("LightingVertex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 430 core
        ///
        ///layout(location = 0) out vec4 colour;
        ///
        ///in vec2 tex_Coords;
        ///
        ///uniform sampler2D uTextureSlot;
        ///
        ///uniform int screenWidth;
        ///uniform int screenHeight;
        ///
        ///uniform vec2 bitCrush;
        ///uniform bool crushBit;
        ///
        ///uniform bool greyScale;
        ///uniform bool invertedColour;
        ///
        ///uniform bool useKernel;
        ///uniform float[9] kernel;
        ///uniform float kernelOffset = 700.0;
        ///
        ///void main()
        ///{
        ///    vec2 coords = tex_Coords;
        ///
        ///    if (crushBit)
        ///    {
        ///        float x = tex_Coords.x;
        ///
        ///        x = floor(x * bitCrush [rest of string was truncated]&quot;;.
        /// </summary>
        public static string PostFragment {
            get {
                return ResourceManager.GetString("PostFragment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 330 core
        ///
        ///layout(location = locations.vertex) in vec2 vPosition;
        ///layout(location = locations.texture) in vec2 texCoord;
        ///
        ///out vec2 tex_Coords;
        ///
        ///void main()
        ///{
        ///	tex_Coords = texCoord;
        ///
        ///	gl_Position = vec4(vPosition * vec2(2.0), 0, 1);
        ///}.
        /// </summary>
        public static string PostVertex {
            get {
                return ResourceManager.GetString("PostVertex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 330 core
        ///
        ///layout(location = 0) out vec4 colour;
        ///
        ///in vec2 tex_Coords;
        ///in float charSelect;
        ///
        ///uniform sampler2D uTextureSlot;
        ///uniform vec4 uColour;
        ///
        ///uniform vec4 uSelectColour;
        ///uniform vec4 uSelectTextColour;
        ///
        ///void main()
        ///{
        ///	// Get texel
        ///	vec4 tex = texture(uTextureSlot, tex_Coords);
        ///	
        ///	if (charSelect != 0)
        ///	{
        ///		// Use texel as a mix between backgroud and forgroud text colours
        ///		colour = mix(uSelectColour, uSelectTextColour, tex.r);
        ///		return;
        ///	}
        ///
        ///	// Use texel as opacity
        ///	col [rest of string was truncated]&quot;;.
        /// </summary>
        public static string TextEditFrag {
            get {
                return ResourceManager.GetString("TextEditFrag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 330 core
        ///
        ///layout(location = locations.vertex) in vec3 vPosition;
        ///layout(location = locations.texture) in vec2 texCoord;
        ///// Instance data
        ///layout(location = 3) in vec2 offset;
        ///layout(location = 6) in vec2 size;
        ///layout(location = 4) in vec2 texOffset;
        ///layout(location = 5) in vec2 texSize;
        ///layout(location = 7) in vec2 selected;
        ///
        ///out vec2 tex_Coords;
        ///out float charSelect;
        ///
        ///uniform mat4 matrix;
        ///
        ///void main()
        ///{
        ///	tex_Coords = (texCoord * texSize) + texOffset;
        ///	
        ///	if (selected == vec2(0))
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        public static string TextEditVert {
            get {
                return ResourceManager.GetString("TextEditVert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 330 core
        ///
        ////***********************************************************************
        ///*
        ///* Copyright (c) 2019-2022 Barbara Geller
        ///* Copyright (c) 2019-2022 Ansel Sermersheim
        ///*
        ///* This file is part of CsPaint.
        ///*
        ///* CsPaint is free software, released under the BSD 2-Clause license.
        ///* For license details refer to LICENSE provided with this project.
        ///*
        ///* CopperSpice is distributed in the hope that it will be useful,
        ///* but WITHOUT ANY WARRANTY; without even the implied warranty of
        ///* MERCHANTABILI [rest of string was truncated]&quot;;.
        /// </summary>
        public static string TextFrag {
            get {
                return ResourceManager.GetString("TextFrag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 330 core
        ///
        ///layout(location = 1) in vec3 vPosition;
        ///layout(location = locations.texture) in vec2 texCoord;
        ///// Instance data
        ///layout(location = 3) in vec2 offset;
        ///layout(location = 6) in vec2 size;
        ///layout(location = 4) in vec2 texOffset;
        ///layout(location = 5) in vec2 texSize;
        ///
        ///out vec2 tex_Coords;
        ///out vec4 charColour;
        ///
        ///uniform mat4 matrix;
        ///
        ///void main()
        ///{
        ///	tex_Coords = (texCoord * texSize) + texOffset;
        ///
        ///	gl_Position = matrix * vec4((vPosition.xy * size) + offset, vPosition.z, 1);
        ///}.
        /// </summary>
        public static string TextVert {
            get {
                return ResourceManager.GetString("TextVert", resourceCulture);
            }
        }
    }
}
