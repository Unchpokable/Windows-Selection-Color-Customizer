using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EasySelectionColor.WinAPI
{
    internal static class WinAPI
    {
        public const int CS_DROPSHADOW = 0x20000;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRegion(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidth, int nHeight);

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        public static extern bool DeleteObject(IntPtr hObject);
    }
}
