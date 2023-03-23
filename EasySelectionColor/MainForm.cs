using System.ComponentModel;
using System.Diagnostics;
using Cyotek.Windows.Forms;
using static EasySelectionColor.WinAPI.WinAPI;

namespace EasySelectionColor
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        [Description("Form Corner Radius")]
        [Category("View")]
        public int CornerRadius { get; set; }

        private Point _mouseLocation;
        private Pen _outlinePen;
        private Brush _fillBrush;

        private string _defaultHilightColor = "0 120 215";
        private string _defaultHotTrackingColor = "0 102 204";

        private void Form1_Load(object sender, EventArgs e)
        {
#pragma warning disable CS8622 // STOP FUCK MY BRAIN WITH NULL-NOT-NULL THINGS DEAR .NET PLEASE FUCK YOU
            DragPanel.MouseDown += OnMouseDown;
            DragPanel.MouseMove += OnMouseMove;
            label1.MouseDown += OnMouseDown;
            label1.MouseMove += OnMouseMove;
#pragma warning restore CS8622

            CornerRadius = 10;

            var regWriter = new RegistryWriter();
            var outlineColor = regWriter.GetControlPanelColorsValue("Hilight")?.ToString().Split(' ').Select(x => int.Parse(x)).ToList();
            SelectionOutlineColorbox.BackColor = Color.FromArgb(200, outlineColor[0], outlineColor[1], outlineColor[2]);

            var fillColor = regWriter.GetControlPanelColorsValue("HotTrackingColor")?.ToString().Split(' ').Select(x => int.Parse(x)).ToList();
            FillColorbox.BackColor = Color.FromArgb(100, fillColor[0], fillColor[1], fillColor[2]);

            _outlinePen = new Pen(SelectionOutlineColorbox.BackColor);
            _fillBrush = new SolidBrush(Color.FromArgb(100, SelectionOutlineColorbox.BackColor));

            AllowTransparency = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawSelectionPreview();
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(255, 46, 46, 46), ButtonBorderStyle.Solid);
        }

        private void DrawSelectionPreview()
        {
            var transparentBmp = new Bitmap(PreviewBox.Width, PreviewBox.Height);
            transparentBmp.MakeTransparent();

            using var graphics = Graphics.FromImage(transparentBmp);

            graphics.FillRectangle(_fillBrush, 150, 150, 150, 150);
            graphics.DrawRectangle(_outlinePen, 150, 150, 150, 150);

            PreviewBox.Image = transparentBmp;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            _mouseLocation = e.Location;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var dx = e.Location.X - _mouseLocation.X;
                var dy = e.Location.Y - _mouseLocation.Y;
                Location = new Point(Location.X + dx, Location.Y + dy);
            }
        }

        private void RoundedButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ApplyChanges(object sender, EventArgs e)
        {
            WriteColors(SelectionOutlineColorbox.BackColor.ToRGBString(), FillColorbox.BackColor.ToRGBString());
        }

        private void WriteColors(string hightlighColor, string hotTrackingColor)
        {
            var regIO = new RegistryWriter();
            try
            {
                regIO.SetControlPanelColorsValue("Hilight", hightlighColor);
                regIO.SetControlPanelColorsValue("HotTrackingColor", hotTrackingColor);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception during writing registry: {ex.GetType()} {ex.Message}");
                return;
            }

            MessageBox.Show("Done! Relogin your windows profile or reboot PC to see changes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SelectColor(object sender, EventArgs e)
        {
            var btn = sender as Button;

            var colorDialog = new ColorPickerDialog() { Color = SelectionOutlineColorbox.BackColor };
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (btn.Name == nameof(OutlineColorSelector))
                {
                    SelectionOutlineColorbox.BackColor = colorDialog.Color;
                    _outlinePen = new Pen(Color.FromArgb(240, colorDialog.Color));
                }
                if (btn.Name == nameof(FillColorSelector))
                {
                    FillColorbox.BackColor = colorDialog.Color;
                    _fillBrush = new SolidBrush(Color.FromArgb(127, colorDialog.Color));
                }
            }
            DrawSelectionPreview();
        }

        private void ResetColors(object sender, EventArgs e)
        {
            WriteColors(_defaultHilightColor, _defaultHotTrackingColor);
        }
    }
}