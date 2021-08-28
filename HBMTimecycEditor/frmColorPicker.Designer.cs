
namespace HBMTimecycEditor
{
    partial class frmColorPicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColorPicker));
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.googleColorPicker1 = new ColorPicker.GoogleColorPicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // egoldsFormStyle1
            // 
            this.egoldsFormStyle1.AllowUserResize = false;
            this.egoldsFormStyle1.BackColor = System.Drawing.Color.White;
            this.egoldsFormStyle1.ContextMenuForm = null;
            this.egoldsFormStyle1.ControlBoxButtonsWidth = 20;
            this.egoldsFormStyle1.EnableControlBoxIconsLight = false;
            this.egoldsFormStyle1.EnableControlBoxMouseLight = false;
            this.egoldsFormStyle1.Form = this;
            this.egoldsFormStyle1.FormStyle = yt_DesignUI.Components.EgoldsFormStyle.fStyle.SimpleDark;
            this.egoldsFormStyle1.HeaderColor = System.Drawing.Color.DarkCyan;
            this.egoldsFormStyle1.HeaderColorAdditional = System.Drawing.Color.Teal;
            this.egoldsFormStyle1.HeaderColorGradientEnable = true;
            this.egoldsFormStyle1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.egoldsFormStyle1.HeaderHeight = 38;
            this.egoldsFormStyle1.HeaderImage = null;
            this.egoldsFormStyle1.HeaderTextColor = System.Drawing.Color.White;
            this.egoldsFormStyle1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.googleColorPicker1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 285);
            this.panel1.TabIndex = 1;
            // 
            // googleColorPicker1
            // 
            this.googleColorPicker1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.googleColorPicker1.Location = new System.Drawing.Point(0, 0);
            this.googleColorPicker1.Name = "googleColorPicker1";
            this.googleColorPicker1.Size = new System.Drawing.Size(256, 285);
            this.googleColorPicker1.TabIndex = 0;
            this.googleColorPicker1.ColorChanged += new System.EventHandler(this.googleColorPicker1_ColorChanged);
            // 
            // frmColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 289);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(257, 327);
            this.MinimumSize = new System.Drawing.Size(257, 327);
            this.Name = "frmColorPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private yt_DesignUI.Components.EgoldsFormStyle egoldsFormStyle1;
        private System.Windows.Forms.Panel panel1;
        private ColorPicker.GoogleColorPicker googleColorPicker1;
    }
}