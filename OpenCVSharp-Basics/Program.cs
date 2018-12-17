using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace OpenCVSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            displayImage(images[0], ImreadModes.Color);
            displayImage(images[0], ImreadModes.Grayscale);
            displayImage(images[0], ImreadModes.ReducedGrayscale8);

        }

        private static string[] images = new[] { "images/lake-1200.jpg" };
        public static void displayImage(string path, ImreadModes mode)
        {
            Mat img = Cv2.ImRead(path, mode);
            string title = extractTitle(path);
            Cv2.ImShow(title,img);
            Cv2.WaitKey();
            Cv2.DestroyAllWindows();

        }

        public static string extractTitle(string text)
        {
            string title = text.Split('/')[1].Split('.')[0];

            return title;
        }
    }
}
