namespace ColorPicker
{
    partial class GoogleColorPicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel = new ColorPicker.HsvPanel();
            this.slider = new ColorPicker.HueSlider();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.slider, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 285);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Hue = 150F;
            this.panel.Location = new System.Drawing.Point(3, 3);
            this.panel.Name = "panel";
            this.panel.Saturation = 0.177035F;
            this.panel.Size = new System.Drawing.Size(250, 250);
            this.panel.TabIndex = 1;
            this.panel.Value = 0.5F;
            this.panel.ColorChanged += new System.EventHandler(this.panel_ColorChanged);
            // 
            // slider
            // 
            this.slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slider.Location = new System.Drawing.Point(3, 259);
            this.slider.Name = "slider";
            this.slider.NubSize = new System.Drawing.Size(15, 15);
            this.slider.NubStyle = Cyotek.Windows.Forms.ColorSliderNubStyle.None;
            this.slider.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(127)))));
            this.slider.Size = new System.Drawing.Size(250, 23);
            this.slider.TabIndex = 2;
            this.slider.Value = 150F;
            this.slider.ValueChanged += new System.EventHandler(this.slider_ValueChanged);
            // 
            // GoogleColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GoogleColorPicker";
            this.Size = new System.Drawing.Size(256, 285);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private HsvPanel panel;
        private HueSlider slider;
    }
}
