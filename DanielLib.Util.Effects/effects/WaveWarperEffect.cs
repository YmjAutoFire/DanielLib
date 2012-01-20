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
	
	/// <summary>An effect that applies a wave pattern to the input.</summary>
	public class WaveWarperEffect : ShaderEffect {
		public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(WaveWarperEffect), 0);
		public static readonly DependencyProperty TimeProperty = DependencyProperty.Register("Time", typeof(double), typeof(WaveWarperEffect), new UIPropertyMetadata(((double)(0D)), PixelShaderConstantCallback(0)));
		public static readonly DependencyProperty WaveSizeProperty = DependencyProperty.Register("WaveSize", typeof(double), typeof(WaveWarperEffect), new UIPropertyMetadata(((double)(64D)), PixelShaderConstantCallback(1)));
		public WaveWarperEffect() {
			PixelShader pixelShader = new PixelShader();
            pixelShader.UriSource = new Uri("/Daniellib.Util.Effects;component/effects/ps/WaveWarper.ps", UriKind.Relative);
			this.PixelShader = pixelShader;

			this.UpdateShaderValue(InputProperty);
			this.UpdateShaderValue(TimeProperty);
			this.UpdateShaderValue(WaveSizeProperty);
		}
		public Brush Input {
			get {
				return ((Brush)(this.GetValue(InputProperty)));
			}
			set {
				this.SetValue(InputProperty, value);
			}
		}
		public double Time {
			get {
				return ((double)(this.GetValue(TimeProperty)));
			}
			set {
				this.SetValue(TimeProperty, value);
			}
		}
		/// <summary>The distance between waves. (the higher the value the closer the waves are to their neighbor).</summary>
		public double WaveSize {
			get {
				return ((double)(this.GetValue(WaveSizeProperty)));
			}
			set {
				this.SetValue(WaveSizeProperty, value);
			}
		}
	}
}
