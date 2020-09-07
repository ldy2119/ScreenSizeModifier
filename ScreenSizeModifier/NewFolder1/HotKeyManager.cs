  using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ScreenSizeModifier.NewFolder1
{
    class HotKeyManager
    {
        //핫키등록

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        

        //public HotKeyManager(Window window)
        //{
        //    RegisterHotKey(
        //}
    }
}
