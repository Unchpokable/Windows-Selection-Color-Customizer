namespace EasySelectionColor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            roundedButton1 = new RoundedButton();
            label1 = new Label();
            label2 = new Label();
            PreviewBox = new PictureBox();
            DragPanel = new PictureBox();
            label3 = new Label();
            SelectionOutlineColorbox = new RoundedPictureBox();
            OutlineColorSelector = new RoundedButton();
            label4 = new Label();
            FillColorbox = new RoundedPictureBox();
            FillColorSelector = new RoundedButton();
            roundedButton2 = new RoundedButton();
            roundedButton3 = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)PreviewBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DragPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectionOutlineColorbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FillColorbox).BeginInit();
            SuspendLayout();
            // 
            // roundedButton1
            // 
            roundedButton1.CornerRadius = 10;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton1.ForeColor = Color.WhiteSmoke;
            roundedButton1.Location = new Point(767, 5);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(28, 27);
            roundedButton1.TabIndex = 0;
            roundedButton1.Text = "X";
            roundedButton1.UseVisualStyleBackColor = true;
            roundedButton1.Click += RoundedButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(174, 19);
            label1.TabIndex = 1;
            label1.Text = "Easy Selection Color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(371, 61);
            label2.Name = "label2";
            label2.Size = new Size(75, 18);
            label2.TabIndex = 2;
            label2.Text = "Preview:";
            // 
            // PreviewBox
            // 
            PreviewBox.BackgroundImage = Resources.wallpaper_downscaled;
            PreviewBox.BackgroundImageLayout = ImageLayout.Stretch;
            PreviewBox.Location = new Point(371, 82);
            PreviewBox.Name = "PreviewBox";
            PreviewBox.Size = new Size(417, 356);
            PreviewBox.TabIndex = 3;
            PreviewBox.TabStop = false;
            // 
            // DragPanel
            // 
            DragPanel.Location = new Point(194, 9);
            DragPanel.Name = "DragPanel";
            DragPanel.Size = new Size(567, 18);
            DragPanel.TabIndex = 4;
            DragPanel.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(11, 61);
            label3.Name = "label3";
            label3.Size = new Size(186, 18);
            label3.TabIndex = 5;
            label3.Text = "Selection Outline Color:";
            // 
            // SelectionOutlineColorbox
            // 
            SelectionOutlineColorbox.CornerRadius = 10;
            SelectionOutlineColorbox.Location = new Point(13, 94);
            SelectionOutlineColorbox.Name = "SelectionOutlineColorbox";
            SelectionOutlineColorbox.Size = new Size(318, 54);
            SelectionOutlineColorbox.TabIndex = 6;
            SelectionOutlineColorbox.TabStop = false;
            // 
            // OutlineColorSelector
            // 
            OutlineColorSelector.BackColor = Color.LightCyan;
            OutlineColorSelector.CornerRadius = 10;
            OutlineColorSelector.FlatAppearance.BorderSize = 0;
            OutlineColorSelector.FlatStyle = FlatStyle.Flat;
            OutlineColorSelector.Location = new Point(11, 154);
            OutlineColorSelector.Name = "OutlineColorSelector";
            OutlineColorSelector.Size = new Size(320, 23);
            OutlineColorSelector.TabIndex = 7;
            OutlineColorSelector.Text = "Select";
            OutlineColorSelector.UseVisualStyleBackColor = false;
            OutlineColorSelector.Click += SelectColor;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(11, 207);
            label4.Name = "label4";
            label4.Size = new Size(155, 18);
            label4.TabIndex = 8;
            label4.Text = "Selection Fill Color:";
            // 
            // FillColorbox
            // 
            FillColorbox.CornerRadius = 10;
            FillColorbox.Location = new Point(13, 228);
            FillColorbox.Name = "FillColorbox";
            FillColorbox.Size = new Size(318, 54);
            FillColorbox.TabIndex = 9;
            FillColorbox.TabStop = false;
            // 
            // FillColorSelector
            // 
            FillColorSelector.BackColor = Color.LightCyan;
            FillColorSelector.CornerRadius = 10;
            FillColorSelector.FlatAppearance.BorderSize = 0;
            FillColorSelector.FlatStyle = FlatStyle.Flat;
            FillColorSelector.Location = new Point(13, 288);
            FillColorSelector.Name = "FillColorSelector";
            FillColorSelector.Size = new Size(318, 23);
            FillColorSelector.TabIndex = 10;
            FillColorSelector.Text = "Select";
            FillColorSelector.UseVisualStyleBackColor = false;
            FillColorSelector.Click += SelectColor;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.LightCyan;
            roundedButton2.CornerRadius = 10;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton2.Location = new Point(13, 370);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(318, 39);
            roundedButton2.TabIndex = 11;
            roundedButton2.Text = "Apply!";
            roundedButton2.UseVisualStyleBackColor = false;
            roundedButton2.Click += ApplyChanges;
            // 
            // roundedButton3
            // 
            roundedButton3.BackColor = Color.LightCyan;
            roundedButton3.CornerRadius = 10;
            roundedButton3.FlatAppearance.BorderSize = 0;
            roundedButton3.FlatStyle = FlatStyle.Flat;
            roundedButton3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton3.Location = new Point(13, 415);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(318, 23);
            roundedButton3.TabIndex = 12;
            roundedButton3.Text = "Reset Default";
            roundedButton3.UseVisualStyleBackColor = false;
            roundedButton3.Click += ResetColors;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 453);
            Controls.Add(roundedButton3);
            Controls.Add(roundedButton2);
            Controls.Add(FillColorSelector);
            Controls.Add(FillColorbox);
            Controls.Add(label4);
            Controls.Add(OutlineColorSelector);
            Controls.Add(SelectionOutlineColorbox);
            Controls.Add(label3);
            Controls.Add(DragPanel);
            Controls.Add(PreviewBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(roundedButton1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PreviewBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DragPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectionOutlineColorbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)FillColorbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton roundedButton1;
        private Label label1;
        private Label label2;
        private PictureBox DragPanel;
        private Label label3;
        private RoundedPictureBox SelectionOutlineColorbox;
        private RoundedButton OutlineColorSelector;
        private Label label4;
        private RoundedPictureBox FillColorbox;
        private RoundedButton FillColorSelector;
        private RoundedButton roundedButton2;
        private PictureBox PreviewBox;
        private RoundedButton roundedButton3;
    }
}