using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Surface;
using Microsoft.Surface.Presentation;
using Microsoft.Surface.Presentation.Controls;
using Microsoft.Surface.Presentation.Input;
using DanielLib.Utilities.AudioHandler;
using DanielLib.Utilities.Extentions;

namespace DanielLib.TouchAppTemplate
{
    /// <summary>
    /// Interaction logic for SurfaceWindow1.xaml
    /// </summary>
    public partial class SurfaceWindow1 : SurfaceWindow
    {
        #region SurfaceWindow 参数

        // 全局参数;
        private int ScreenWidth = 1920;
        // 音效管理器;
        public static readonly Dictionary<String, String> audioFiles;
        private AudioManager audioManager;
        private double Volume = 0.5;
        private String SoundDirectory = @"Resources\\Sound";
        // 音效事件;
        public delegate void AudioEventHandler(object sender, AudioEventArgs e);
        public static readonly RoutedEvent AudioEvent = EventManager.RegisterRoutedEvent("Audio", RoutingStrategy.Bubble, typeof(AudioEventHandler), typeof(SurfaceWindow1));
        public event AudioEventHandler Audio
        {
            add { AddHandler(AudioEvent, value); }
            remove { RemoveHandler(AudioEvent, value); }
        }

        #endregion

        #region SurfaceWindow 构造函数

        /// <summary>
        /// Default constructor.
        /// </summary>
        static SurfaceWindow1()
        {
            audioFiles = new Dictionary<String, String>();
            audioFiles.Add("Load", "load.mp3");
        }
        public SurfaceWindow1()
        {
            InitializeComponent();
            AddWindowAvailabilityHandlers();

            audioManager = new AudioManager(this.ScreenWidth, this.Volume, this.SoundDirectory, audioFiles);
            this.Audio += new AudioEventHandler(Main_Audio);

            //RaiseEvent(new AudioEventArgs(SurfaceWindow1.AudioEvent, this) { Audio = "Load"});
        }

        #endregion

        void Main_Audio(object sender, AudioEventArgs e)
        {
            this.audioManager.PlayAudio(e);
        }

        #region SurfaceWindow WindowHandler

        /// <summary>
        /// Occurs when the window is about to close. 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            // Remove handlers for window availability events
            RemoveWindowAvailabilityHandlers();
        }

        /// <summary>
        /// Adds handlers for window availability events.
        /// </summary>
        private void AddWindowAvailabilityHandlers()
        {
            // Subscribe to surface window availability events
            ApplicationServices.WindowInteractive += OnWindowInteractive;
            ApplicationServices.WindowNoninteractive += OnWindowNoninteractive;
            ApplicationServices.WindowUnavailable += OnWindowUnavailable;
        }

        /// <summary>
        /// Removes handlers for window availability events.
        /// </summary>
        private void RemoveWindowAvailabilityHandlers()
        {
            // Unsubscribe from surface window availability events
            ApplicationServices.WindowInteractive -= OnWindowInteractive;
            ApplicationServices.WindowNoninteractive -= OnWindowNoninteractive;
            ApplicationServices.WindowUnavailable -= OnWindowUnavailable;
        }

        /// <summary>
        /// This is called when the user can interact with the application's window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowInteractive(object sender, EventArgs e)
        {
            //TODO: enable audio, animations here
        }

        /// <summary>
        /// This is called when the user can see but not interact with the application's window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowNoninteractive(object sender, EventArgs e)
        {
            //TODO: Disable audio here if it is enabled

            //TODO: optionally enable animations here
        }

        /// <summary>
        /// This is called when the application's window is not visible or interactive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowUnavailable(object sender, EventArgs e)
        {
            //TODO: disable audio, animations here
        }

        #endregion
    }
}