﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Animation;
using System.Windows;

namespace DanielLib.Surface.Presentation
{

    public class ExpoPointEasingAnimation : PointAnimationBase
    {
        public static readonly DependencyProperty FromValueProperty =
            DependencyProperty.Register(
                "FromValue", typeof(Point), typeof(ExpoPointEasingAnimation), new PropertyMetadata(new Point(0,0)));

        public static readonly DependencyProperty ToValueProperty =
            DependencyProperty.Register(
                "ToValue", typeof(Point), typeof(ExpoPointEasingAnimation), new PropertyMetadata(new Point(0,0)));


        public static readonly DependencyProperty EaseFunctionProperty =
            DependencyProperty.Register(
                "EaseFunction", typeof(PointEasingMode), typeof(ExpoPointEasingAnimation), new PropertyMetadata(PointEasingMode.EaseInOut));

        public Point FromValue
        {
            get
            {
                return (Point)GetValue(FromValueProperty);
            }
            set
            {
                SetValue(FromValueProperty, value);
            }
        }

        public Point ToValue
        {
            get
            {
                return (Point)GetValue(ToValueProperty);
            }
            set
            {
                SetValue(ToValueProperty, value);
            }
        }

        public PointEasingMode EaseFunction
        {
            get
            {
                return (PointEasingMode)GetValue(EaseFunctionProperty);
            }
            set
            {
                SetValue(EaseFunctionProperty, value);
            }
        }

        public ExpoPointEasingAnimation()
        {
        }

        /// <summary>
        /// Set Properties
        /// </summary>
        /// <param name="from">Start Point</param>
        /// <param name="to">End Point</param>
        /// <param name="easeInMethod">Easing method equation</param>
        /// <param name="duration">Duration for the animation</param>
        public ExpoPointEasingAnimation(Point from, Point to, PointEasingMode easeInMethod, Duration duration)
        {
            FromValue = from;
            ToValue = to;
            Duration = duration;
            EaseFunction = easeInMethod;
        }

        protected override Freezable CreateInstanceCore()
        {
            return new QuadPointEasingAnimation();
        }

        /// <summary>
        /// Work out which type of animation is needed
        /// </summary>
        /// <param name="defaultOriginValue">default start value</param>
        /// <param name="defaultDestinationValue">default end value</param>
        /// <param name="animationClock">Animaiton to run</param>
        /// <returns></returns>
        protected override Point GetCurrentValueCore(Point defaultOriginValue, Point defaultDestinationValue, AnimationClock animationClock)
        {
            double returnValueX = 0;
            double returnValueY = 0;

            double time = animationClock.CurrentTime.Value.TotalSeconds;
            double startValueX = FromValue.X;
            double eqFinalValueX = ToValue.X - FromValue.X;

            double startValueY = FromValue.Y;
            double eqFinalValueY = ToValue.Y - FromValue.Y;
            double duration = Duration.TimeSpan.TotalSeconds;


            switch (this.EaseFunction)
            {
                case PointEasingMode.EaseIn:
                    if (time == 0)
                    {
                        returnValueX = startValueX;
                        returnValueY = startValueY;
                    }
                    else
                    {
                        returnValueX = eqFinalValueX * Math.Pow(2, 10 * (time / duration - 1)) + startValueX;
                        returnValueY = eqFinalValueY * Math.Pow(2, 10 * (time / duration - 1)) + startValueY;
                    }    
                    break;
                case PointEasingMode.EaseOut:
                    if (time == duration)
                    {
                        returnValueX = startValueX + eqFinalValueX;
                        returnValueY = startValueY + eqFinalValueY;
                    }
                    else
                    {
                        returnValueX = eqFinalValueX * (-Math.Pow(2, -10 * time / duration) + 1) + startValueX;
                        returnValueY = eqFinalValueY * (-Math.Pow(2, -10 * time / duration) + 1) + startValueY;
                    }
                    break;
                case PointEasingMode.EaseInOut:
                    if (time == 0)
                    {
                        returnValueX = startValueX;
                        returnValueY = startValueY;
                    }
                    else if (time == duration)
                    {
                        returnValueX = startValueX + eqFinalValueX;
                        returnValueY = startValueY + eqFinalValueY;
                    }
                    else if ((time /= duration / 2) < 1)
                    {
                        returnValueX = eqFinalValueX / 2 * Math.Pow(2, 10 * (time - 1)) + startValueX;
                        returnValueY = eqFinalValueY / 2 * Math.Pow(2, 10 * (time - 1)) + startValueY;
                    }
                    else
                    {
                        returnValueX = eqFinalValueX / 2 * (-Math.Pow(2, -10 * --time) + 2) + startValueX;
                        returnValueY = eqFinalValueY / 2 * (-Math.Pow(2, -10 * --time) + 2) + startValueY;
                    }     
                    break;
                default:
                    break;
            }

            return new Point(returnValueX, returnValueY);
        }
    }
}
