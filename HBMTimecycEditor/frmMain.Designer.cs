
namespace HBMTimecycEditor
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cbWeather = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDrawDist = new System.Windows.Forms.Panel();
            this.btnChange = new yt_DesignUI.yt_Button();
            this.tgglMultiselect = new yt_DesignUI.EgoldsToggleSwitch();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.tbDraw = new yt_DesignUI.EgoldsGoogleTextBox();
            this.tbLightOnGround = new yt_DesignUI.EgoldsGoogleTextBox();
            this.btnEdit = new yt_DesignUI.yt_Button();
            this.tbFog = new yt_DesignUI.EgoldsGoogleTextBox();
            this.tbSpriteBright = new yt_DesignUI.EgoldsGoogleTextBox();
            this.pnlOneSelect = new System.Windows.Forms.Panel();
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            this.tbPath = new yt_DesignUI.EgoldsGoogleTextBox();
            this.btnBrowse = new yt_DesignUI.yt_Button();
            this.pnlDrawDist.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.pnlOneSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbWeather
            // 
            this.cbWeather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeather.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbWeather.FormattingEnabled = true;
            this.cbWeather.Items.AddRange(new object[] {
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
            this.cbWeather.Location = new System.Drawing.Point(7, 23);
            this.cbWeather.Name = "cbWeather";
            this.cbWeather.Size = new System.Drawing.Size(208, 24);
            this.cbWeather.TabIndex = 7;
            this.cbWeather.SelectedIndexChanged += new System.EventHandler(this.CbWeather_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Weather";
            // 
            // cbTime
            // 
            this.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "ALL",
            "Midnight",
            "5 AM",
            "6 AM",
            "7 AM",
            "Midday",
            "7 PM",
            "8 PM",
            "10 PM"});
            this.cbTime.Location = new System.Drawing.Point(221, 23);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(84, 24);
            this.cbTime.TabIndex = 8;
            this.cbTime.SelectedIndexChanged += new System.EventHandler(this.CbTime_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(219, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            // 
            // pnlDrawDist
            // 
            this.pnlDrawDist.Controls.Add(this.btnChange);
            this.pnlDrawDist.Controls.Add(this.tgglMultiselect);
            this.pnlDrawDist.Controls.Add(this.pnlEdit);
            this.pnlDrawDist.Controls.Add(this.pnlOneSelect);
            this.pnlDrawDist.Location = new System.Drawing.Point(1, 57);
            this.pnlDrawDist.Name = "pnlDrawDist";
            this.pnlDrawDist.Size = new System.Drawing.Size(434, 142);
            this.pnlDrawDist.TabIndex = 0;
            this.pnlDrawDist.Click += new System.EventHandler(this.PnlOneSelect_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.DarkCyan;
            this.btnChange.BackColorAdditional = System.Drawing.Color.Gray;
            this.btnChange.BackColorGradientEnabled = false;
            this.btnChange.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnChange.BorderColor = System.Drawing.Color.Black;
            this.btnChange.BorderColorEnabled = false;
            this.btnChange.BorderColorOnHover = System.Drawing.Color.LightSeaGreen;
            this.btnChange.BorderColorOnHoverEnabled = false;
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(358, 17);
            this.btnChange.Name = "btnChange";
            this.btnChange.RippleColor = System.Drawing.Color.Black;
            this.btnChange.RoundingEnable = true;
            this.btnChange.Size = new System.Drawing.Size(70, 34);
            this.btnChange.TabIndex = 14;
            this.btnChange.Text = "Change";
            this.btnChange.TextHover = null;
            this.btnChange.UseDownPressEffectOnClick = false;
            this.btnChange.UseRippleEffect = true;
            this.btnChange.UseZoomEffectOnHover = false;
            this.btnChange.Visible = false;
            this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // tgglMultiselect
            // 
            this.tgglMultiselect.BackColor = System.Drawing.Color.White;
            this.tgglMultiselect.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.tgglMultiselect.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.tgglMultiselect.Checked = false;
            this.tgglMultiselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgglMultiselect.Font = new System.Drawing.Font("Verdana", 9F);
            this.tgglMultiselect.Location = new System.Drawing.Point(312, 27);
            this.tgglMultiselect.Name = "tgglMultiselect";
            this.tgglMultiselect.Size = new System.Drawing.Size(116, 15);
            this.tgglMultiselect.TabIndex = 12;
            this.tgglMultiselect.Text = "Multiselect";
            this.tgglMultiselect.TextOnChecked = "";
            this.tgglMultiselect.CheckedChanged += new yt_DesignUI.EgoldsToggleSwitch.OnCheckedChangedHandler(this.TgglMultiselect_CheckedChanged);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.tbDraw);
            this.pnlEdit.Controls.Add(this.tbLightOnGround);
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.Controls.Add(this.tbFog);
            this.pnlEdit.Controls.Add(this.tbSpriteBright);
            this.pnlEdit.Location = new System.Drawing.Point(0, 53);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(434, 89);
            this.pnlEdit.TabIndex = 14;
            // 
            // tbDraw
            // 
            this.tbDraw.BackColor = System.Drawing.Color.White;
            this.tbDraw.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbDraw.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbDraw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDraw.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbDraw.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbDraw.ForeColor = System.Drawing.Color.Black;
            this.tbDraw.Location = new System.Drawing.Point(7, 0);
            this.tbDraw.Name = "tbDraw";
            this.tbDraw.SelectionStart = 0;
            this.tbDraw.Size = new System.Drawing.Size(145, 40);
            this.tbDraw.TabIndex = 5;
            this.tbDraw.TextInput = "";
            this.tbDraw.TextPreview = "Draw distance";
            this.tbDraw.UseSystemPasswordChar = false;
            this.tbDraw.TextChanged += new System.EventHandler(this.TbDraw_TextChanged);
            // 
            // tbLightOnGround
            // 
            this.tbLightOnGround.BackColor = System.Drawing.Color.White;
            this.tbLightOnGround.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbLightOnGround.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbLightOnGround.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLightOnGround.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbLightOnGround.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbLightOnGround.ForeColor = System.Drawing.Color.Black;
            this.tbLightOnGround.Location = new System.Drawing.Point(158, 43);
            this.tbLightOnGround.Name = "tbLightOnGround";
            this.tbLightOnGround.SelectionStart = 0;
            this.tbLightOnGround.Size = new System.Drawing.Size(147, 40);
            this.tbLightOnGround.TabIndex = 13;
            this.tbLightOnGround.TextInput = "";
            this.tbLightOnGround.TextPreview = "Light on ground";
            this.tbLightOnGround.UseSystemPasswordChar = false;
            this.tbLightOnGround.TextChanged += new System.EventHandler(this.TbLightOnGround_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEdit.BackColorAdditional = System.Drawing.Color.Gray;
            this.btnEdit.BackColorGradientEnabled = false;
            this.btnEdit.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.BorderColorEnabled = false;
            this.btnEdit.BorderColorOnHover = System.Drawing.Color.LightSeaGreen;
            this.btnEdit.BorderColorOnHoverEnabled = false;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(312, 51);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RippleColor = System.Drawing.Color.Black;
            this.btnEdit.RoundingEnable = true;
            this.btnEdit.Size = new System.Drawing.Size(116, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextHover = null;
            this.btnEdit.UseDownPressEffectOnClick = false;
            this.btnEdit.UseRippleEffect = true;
            this.btnEdit.UseZoomEffectOnHover = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // tbFog
            // 
            this.tbFog.BackColor = System.Drawing.Color.White;
            this.tbFog.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbFog.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbFog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFog.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbFog.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbFog.ForeColor = System.Drawing.Color.Black;
            this.tbFog.Location = new System.Drawing.Point(158, 0);
            this.tbFog.Name = "tbFog";
            this.tbFog.SelectionStart = 0;
            this.tbFog.Size = new System.Drawing.Size(147, 40);
            this.tbFog.TabIndex = 9;
            this.tbFog.TextInput = "";
            this.tbFog.TextPreview = "Fog distance";
            this.tbFog.UseSystemPasswordChar = false;
            this.tbFog.TextChanged += new System.EventHandler(this.TbFog_TextChanged);
            // 
            // tbSpriteBright
            // 
            this.tbSpriteBright.BackColor = System.Drawing.Color.White;
            this.tbSpriteBright.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbSpriteBright.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbSpriteBright.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSpriteBright.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbSpriteBright.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbSpriteBright.ForeColor = System.Drawing.Color.Black;
            this.tbSpriteBright.Location = new System.Drawing.Point(7, 43);
            this.tbSpriteBright.Name = "tbSpriteBright";
            this.tbSpriteBright.SelectionStart = 0;
            this.tbSpriteBright.Size = new System.Drawing.Size(145, 40);
            this.tbSpriteBright.TabIndex = 10;
            this.tbSpriteBright.TextInput = "";
            this.tbSpriteBright.TextPreview = "Sprite brightness";
            this.tbSpriteBright.UseSystemPasswordChar = false;
            this.tbSpriteBright.TextChanged += new System.EventHandler(this.TbSpriteBright_TextChanged);
            // 
            // pnlOneSelect
            // 
            this.pnlOneSelect.Controls.Add(this.cbWeather);
            this.pnlOneSelect.Controls.Add(this.cbTime);
            this.pnlOneSelect.Controls.Add(this.label2);
            this.pnlOneSelect.Controls.Add(this.label1);
            this.pnlOneSelect.Location = new System.Drawing.Point(0, 0);
            this.pnlOneSelect.Name = "pnlOneSelect";
            this.pnlOneSelect.Size = new System.Drawing.Size(310, 53);
            this.pnlOneSelect.TabIndex = 11;
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
            // tbPath
            // 
            this.tbPath.BackColor = System.Drawing.Color.White;
            this.tbPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbPath.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPath.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPath.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbPath.ForeColor = System.Drawing.Color.Black;
            this.tbPath.Location = new System.Drawing.Point(8, 11);
            this.tbPath.Name = "tbPath";
            this.tbPath.SelectionStart = 0;
            this.tbPath.Size = new System.Drawing.Size(298, 40);
            this.tbPath.TabIndex = 4;
            this.tbPath.TextInput = "";
            this.tbPath.TextPreview = "GTA path";
            this.tbPath.UseSystemPasswordChar = false;
            this.tbPath.TextChanged += new System.EventHandler(this.TbPath_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBrowse.BackColorAdditional = System.Drawing.Color.Gray;
            this.btnBrowse.BackColorGradientEnabled = false;
            this.btnBrowse.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnBrowse.BorderColor = System.Drawing.Color.Black;
            this.btnBrowse.BorderColorEnabled = false;
            this.btnBrowse.BorderColorOnHover = System.Drawing.Color.LightSeaGreen;
            this.btnBrowse.BorderColorOnHoverEnabled = false;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(313, 17);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.RippleColor = System.Drawing.Color.Black;
            this.btnBrowse.RoundingEnable = true;
            this.btnBrowse.Size = new System.Drawing.Size(116, 34);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextHover = null;
            this.btnBrowse.UseDownPressEffectOnClick = false;
            this.btnBrowse.UseRippleEffect = true;
            this.btnBrowse.UseZoomEffectOnHover = false;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 200);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pnlDrawDist);
            this.Controls.Add(this.tbPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HBM Draw distance editor";
            this.Click += new System.EventHandler(this.FrmMain_Click);
            this.pnlDrawDist.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.pnlOneSelect.ResumeLayout(false);
            this.pnlOneSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlDrawDist;
        private yt_DesignUI.Components.EgoldsFormStyle egoldsFormStyle1;
        private yt_DesignUI.EgoldsGoogleTextBox tbDraw;
        private yt_DesignUI.EgoldsGoogleTextBox tbPath;
        private yt_DesignUI.yt_Button btnEdit;
        private yt_DesignUI.yt_Button btnBrowse;
        private yt_DesignUI.EgoldsGoogleTextBox tbSpriteBright;
        private yt_DesignUI.EgoldsGoogleTextBox tbFog;
        private System.Windows.Forms.Panel pnlOneSelect;
        private yt_DesignUI.EgoldsGoogleTextBox tbLightOnGround;
        private System.Windows.Forms.Panel pnlEdit;
        private yt_DesignUI.yt_Button btnChange;
        public yt_DesignUI.EgoldsToggleSwitch tgglMultiselect;
    }
}

