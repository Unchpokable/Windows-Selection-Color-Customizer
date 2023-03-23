using System.ComponentModel;
using static EasySelectionColor.WinAPI.WinAPI;

namespace EasySelectionColor
{

    internal class RoundedPictureBox : PictureBox
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
