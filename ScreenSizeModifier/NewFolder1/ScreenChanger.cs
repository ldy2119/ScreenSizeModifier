using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ScreenSizeModifier.NewFolder1
{


    public class ScreenChanger
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetActiveWindow();


        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        public void ChangeSize()
        {
            IntPtr activeWindow = GetActiveWindow();

            MoveWindow(activeWindow, 0, 0, Screen.PrimaryScreen.Bounds.Width + 10, Screen.PrimaryScreen.Bounds.Height / 2, true);


        }


    }
}
