using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Windows.Media;
using System.IO;

namespace DanielLib.Utilities.ImageHandler
{
    public class SaveImageToDisk
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr handle);
        public static BitmapSource bs;
        public static IntPtr ip;

        public static BitmapSource LoadBitmap(System.Drawing.Bitmap source)
        {
            ip = source.GetHbitmap();
            bs = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(ip, IntPtr.Zero, System.Windows.Int32Rect.Empty,
                System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
            DeleteObject(ip);
            return bs;
        }

        public static BitmapSource SaveCanvasToJpeg(Canvas mCanvas, string mFileName)
        {
            RenderTargetBitmap targetBitmap = new RenderTargetBitmap((int)mCanvas.ActualWidth, (int)mCanvas.ActualHeight, 96d, 96d, PixelFormats.Default);
            targetBitmap.Render(mCanvas);
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(targetBitmap));
            encoder.QualityLevel = 100;
            FileStream fileStream = File.Open(mFileName, FileMode.Create);
            encoder.Save(fileStream);
            encoder = null;
            fileStream.Close();
            return (BitmapSource)targetBitmap;
        }

        public static BitmapSource SaveCanvasToJpeg(Grid mCanvas, string mFileName)
        {
            RenderTargetBitmap targetBitmap = new RenderTargetBitmap((int)mCanvas.ActualWidth, (int)mCanvas.ActualHeight, 96d, 96d, PixelFormats.Default);
            targetBitmap.Render(mCanvas);
            //JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(targetBitmap));
            //encoder.QualityLevel = 100;
            FileStream fileStream = File.Open(mFileName, FileMode.Create);
            encoder.Save(fileStream);
            encoder = null;
            fileStream.Close();
            return (BitmapSource)targetBitmap;
        }

        public static BitmapSource SaveCanvasToJpeg(Canvas mCanvas, string mFileName, string mRemoteFileName)
        {
            BitmapSource mBS = SaveCanvasToJpeg(mCanvas, mFileName);

            if (mRemoteFileName != string.Empty && mRemoteFileName != "" && mRemoteFileName != null)
            {
                //File.Move(mFileName, mRemoteFileName);
                File.Copy(mFileName, mRemoteFileName);
            }

            return mBS;
        }
    }
}
