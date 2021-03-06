﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Media3D;


namespace Daniellib.Util.Effects
{
	
	/// <summary>Pixel shader: Edge detection using a parametric, symetric, directional convolution kernel</summary>
	public class ParametricEdgeDetection : ShaderEffect {
		public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(ParametricEdgeDetection), 0);
		public static readonly DependencyProperty ThreshholdProperty = DependencyProperty.Register("Threshhold", typeof(double), typeof(ParametricEdgeDetection), new UIPropertyMetadata(((double)(0.5D)), PixelShaderConstantCallback(0)));
		public static readonly DependencyProperty K00Property = DependencyProperty.Register("K00", typeof(double), typeof(ParametricEdgeDetection), new UIPropertyMetadata(((double)(1D)), PixelShaderConstantCallback(1)));
		public static readonly DependencyProperty K01Property = DependencyProperty.Register("K01", typeof(double), typeof(ParametricEdgeDetection), new UIPropertyMetadata(((double)(2D)), PixelShaderConstantCallback(2)));
		public static readonly DependencyProperty K02Property = DependencyProperty.Register("K02", typeof(double), typeof(ParametricEdgeDetection), new UIPropertyMetadata(((double)(1D)), PixelShaderConstantCallback(3)));
		public static readonly DependencyProperty TextureSizeProperty = DependencyProperty.Register("TextureSize", typeof(Point), typeof(ParametricEdgeDetection), new UIPropertyMetadata(new Point(512D, 512D), PixelShaderConstantCallback(4)));
		public ParametricEdgeDetection() {
			PixelShader pixelShader = new PixelShader();
            pixelShader.UriSource = new Uri("/Daniellib.Util.Effects;component/effects/ps/ParametricEdgeDetection.ps", UriKind.Relative);
			this.PixelShader = pixelShader;

			this.UpdateShaderValue(InputProperty);
			this.UpdateShaderValue(ThreshholdProperty);
			this.UpdateShaderValue(K00Property);
			this.UpdateShaderValue(K01Property);
			this.UpdateShaderValue(K02Property);
			this.UpdateShaderValue(TextureSizeProperty);
		}
		public Brush Input {
			get {
				return ((Brush)(this.GetValue(InputProperty)));
			}
			set {
				this.SetValue(InputProperty, value);
			}
		}
		/// <summary>The threshold of the edge detection.</summary>
		public double Threshhold {
			get {
				return ((double)(this.GetValue(ThreshholdProperty)));
			}
			set {
				this.SetValue(ThreshholdProperty, value);
			}
		}
		/// <summary>Kernel first column top. Default is the Sobel operator.</summary>
		public double K00 {
			get {
				return ((double)(this.GetValue(K00Property)));
			}
			set {
				this.SetValue(K00Property, value);
			}
		}
		/// <summary>Kernel first column middle. Default is the Sobel operator.</summary>
		public double K01 {
			get {
				return ((double)(this.GetValue(K01Property)));
			}
			set {
				this.SetValue(K01Property, value);
			}
		}
		/// <summary>Kernel first column bottom. Default is the Sobel operator.</summary>
		public double K02 {
			get {
				return ((double)(this.GetValue(K02Property)));
			}
			set {
				this.SetValue(K02Property, value);
			}
		}
		/// <summary>The size of the texture.</summary>
		public Point TextureSize {
			get {
				return ((Point)(this.GetValue(TextureSizeProperty)));
			}
			set {
				this.SetValue(TextureSizeProperty, value);
			}
		}
	}
}
