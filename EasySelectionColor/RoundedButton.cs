using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static EasySelectionColor.WinAPI.WinAPI;

namespace EasySelectionColor
{
    public class RoundedButton : Button
    {
        [Description("Button Corner Radius")]
        [Category("View")]
        public int CornerRadius { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var roundedReg = CreateRoundRectRegion(0, 0, Width, Height, CornerRadius, CornerRadius);
            Region = Region.FromHrgn(roundedReg);
            DeleteObject(roundedReg);
        }
    }
}
