
namespace HBMTimecycEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.weatherCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DDpanel = new System.Windows.Forms.Panel();
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            this.pathTB = new yt_DesignUI.EgoldsGoogleTextBox();
            this.drawTB = new yt_DesignUI.EgoldsGoogleTextBox();
            this.editBtn = new yt_DesignUI.yt_Button();
            this.browseBtn = new yt_DesignUI.yt_Button();
            this.DDpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // weatherCB
            // 
            this.weatherCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weatherCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weatherCB.FormattingEnabled = true;
            this.weatherCB.Items.AddRange(new object[] {
            "ALL",
            "EXTRASUNNY_LA",
            "SUNNY_LA",
            "EXTRASUNNY_SMOG_LA",
            "SUNNY_SMOG_LA",
            "CLOUDY_LA",
            "SUNNY_SF",
            "EXTRASUNNY_SF",
            "CLOUDY_SF",
            "RAINY_SF",
            "FOGGY_SF",
            "SUNNY_VEGAS",
            "EXTRASUNNY_VEGAS",
            "CLOUDY_VEGAS",
            "EXTRASUNNY_COUNTRYSIDE",
            "SUNNY_COUNTRYSIDE",
            "CLOUDY_COUNTRYSIDE",
            "RAINY_COUNTRYSIDE",
            "EXTRASUNNY_DESERT",
            "SUNNY_DESERT",
            "SANDSTORM_DESERT",
            "UNDERWATER",
            "EXTRACOLOURS_1",
            "EXTRACOLOURS_2"});
            this.weatherCB.Location = new System.Drawing.Point(8, 25);
            this.weatherCB.Name = "weatherCB";
            this.weatherCB.Size = new System.Drawing.Size(208, 24);
            this.weatherCB.TabIndex = 7;
            this.weatherCB.SelectedIndexChanged += new System.EventHandler(this.WeatherCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Weather";
            // 
            // timeCB
            // 
            this.timeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeCB.FormattingEnabled = true;
            this.timeCB.Items.AddRange(new object[] {
            "ALL",
            "Midnight",
            "5 AM",
            "6 AM",
            "7 AM",
            "Midday",
            "7 PM",
            "8 PM",
            "10 PM"});
            this.timeCB.Location = new System.Drawing.Point(222, 25);
            this.timeCB.Name = "timeCB";
            this.timeCB.Size = new System.Drawing.Size(84, 24);
            this.timeCB.TabIndex = 8;
            this.timeCB.SelectedIndexChanged += new System.EventHandler(this.TimeCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(220, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            // 
            // DDpanel
            // 
            this.DDpanel.Controls.Add(this.drawTB);
            this.DDpanel.Controls.Add(this.editBtn);
            this.DDpanel.Controls.Add(this.weatherCB);
            this.DDpanel.Controls.Add(this.label1);
            this.DDpanel.Controls.Add(this.label2);
            this.DDpanel.Controls.Add(this.timeCB);
            this.DDpanel.Location = new System.Drawing.Point(1, 57);
            this.DDpanel.Name = "DDpanel";
            this.DDpanel.Size = new System.Drawing.Size(406, 95);
            this.DDpanel.TabIndex = 0;
            this.DDpanel.Click += new System.EventHandler(this.DDpanel_Click);
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
            // pathTB
            // 
            this.pathTB.BackColor = System.Drawing.Color.White;
            this.pathTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pathTB.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.pathTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathTB.Font = new System.Drawing.Font("Arial", 11.25F);
            this.pathTB.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.pathTB.ForeColor = System.Drawing.Color.Black;
            this.pathTB.Location = new System.Drawing.Point(8, 11);
            this.pathTB.Name = "pathTB";
            this.pathTB.Size = new System.Drawing.Size(298, 40);
            this.pathTB.TabIndex = 4;
            this.pathTB.TextInput = "";
            this.pathTB.TextPreview = "GTA path";
            this.pathTB.UseSystemPasswordChar = false;
            this.pathTB.TextChanged += new System.EventHandler(this.PathTB_TextChanged);
            // 
            // drawTB
            // 
            this.drawTB.BackColor = System.Drawing.Color.White;
            this.drawTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.drawTB.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.drawTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drawTB.Font = new System.Drawing.Font("Arial", 11.25F);
            this.drawTB.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.drawTB.ForeColor = System.Drawing.Color.Black;
            this.drawTB.Location = new System.Drawing.Point(312, 9);
            this.drawTB.Name = "drawTB";
            this.drawTB.Size = new System.Drawing.Size(89, 40);
            this.drawTB.TabIndex = 5;
            this.drawTB.TextInput = "";
            this.drawTB.TextPreview = "Draw dist";
            this.drawTB.UseSystemPasswordChar = false;
            this.drawTB.TextChanged += new System.EventHandler(this.DrawTB_TextChanged);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.editBtn.BackColorAdditional = System.Drawing.Color.Gray;
            this.editBtn.BackColorGradientEnabled = false;
            this.editBtn.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.editBtn.BorderColor = System.Drawing.Color.Black;
            this.editBtn.BorderColorEnabled = false;
            this.editBtn.BorderColorOnHover = System.Drawing.Color.LightSeaGreen;
            this.editBtn.BorderColorOnHoverEnabled = false;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(312, 56);
            this.editBtn.Name = "editBtn";
            this.editBtn.RippleColor = System.Drawing.Color.Black;
            this.editBtn.RoundingEnable = true;
            this.editBtn.Size = new System.Drawing.Size(89, 30);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Edit";
            this.editBtn.TextHover = null;
            this.editBtn.UseDownPressEffectOnClick = false;
            this.editBtn.UseRippleEffect = true;
            this.editBtn.UseZoomEffectOnHover = false;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.browseBtn.BackColorAdditional = System.Drawing.Color.Gray;
            this.browseBtn.BackColorGradientEnabled = false;
            this.browseBtn.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.browseBtn.BorderColor = System.Drawing.Color.Black;
            this.browseBtn.BorderColorEnabled = false;
            this.browseBtn.BorderColorOnHover = System.Drawing.Color.LightSeaGreen;
            this.browseBtn.BorderColorOnHoverEnabled = false;
            this.browseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseBtn.ForeColor = System.Drawing.Color.White;
            this.browseBtn.Location = new System.Drawing.Point(313, 17);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.RippleColor = System.Drawing.Color.Black;
            this.browseBtn.RoundingEnable = true;
            this.browseBtn.Size = new System.Drawing.Size(90, 34);
            this.browseBtn.TabIndex = 6;
            this.browseBtn.Text = "Browse";
            this.browseBtn.TextHover = null;
            this.browseBtn.UseDownPressEffectOnClick = false;
            this.browseBtn.UseRippleEffect = true;
            this.browseBtn.UseZoomEffectOnHover = false;
            this.browseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 153);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.DDpanel);
            this.Controls.Add(this.pathTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HBM Draw distance editor";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.DDpanel.ResumeLayout(false);
            this.DDpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox weatherCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox timeCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DDpanel;
        private yt_DesignUI.Components.EgoldsFormStyle egoldsFormStyle1;
        private yt_DesignUI.EgoldsGoogleTextBox drawTB;
        private yt_DesignUI.EgoldsGoogleTextBox pathTB;
        private yt_DesignUI.yt_Button editBtn;
        private yt_DesignUI.yt_Button browseBtn;
    }
}

