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
	
	/// <summary>An effect that applies a radial blur to the input.</summary>
	public class ZoomBlurEffect : ShaderEffect {
		public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(ZoomBlurEffect), 0);
		public static readonly DependencyProperty CenterProperty = DependencyProperty.Register("Center", typeof(Point), typeof(ZoomBlurEffect), new UIPropertyMetadata(new Point(0.9D, 0.6D), PixelShaderConstantCallback(0)));
		public static readonly DependencyProperty BlurAmountProperty = DependencyProperty.Register("BlurAmount", typeof(double), typeof(ZoomBlurEffect), new UIPropertyMetadata(((double)(0.1D)), PixelShaderConstantCallback(1)));
		public ZoomBlurEffect() {
			PixelShader pixelShader = new PixelShader();
            pixelShader.UriSource = new Uri("/Daniellib.Util.Effects;component/effects/ps/ZoomBlur.ps", UriKind.Relative);
			this.PixelShader = pixelShader;

			this.UpdateShaderValue(InputProperty);
			this.UpdateShaderValue(CenterProperty);
			this.UpdateShaderValue(BlurAmountProperty);
		}
		public Brush Input {
			get {
				return ((Brush)(this.GetValue(InputProperty)));
			}
			set {
				this.SetValue(InputProperty, value);
			}
		}
		/// <summary>The center of the blur.</summary>
		public Point Center {
			get {
				return ((Point)(this.GetValue(CenterProperty)));
			}
			set {
				this.SetValue(CenterProperty, value);
			}
		}
		/// <summary>The amount of blur.</summary>
		public double BlurAmount {
			get {
				return ((double)(this.GetValue(BlurAmountProperty)));
			}
			set {
				this.SetValue(BlurAmountProperty, value);
			}
		}
	}
}
