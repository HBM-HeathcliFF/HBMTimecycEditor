
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
            this.lblWeather = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlDrawDist = new System.Windows.Forms.Panel();
            this.btnShow = new yt_DesignUI.yt_Button();
            this.tgglMultiselect = new yt_DesignUI.EgoldsToggleSwitch();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.tbPoleShading = new yt_DesignUI.EgoldsGoogleTextBox();
            this.tbLightShading = new yt_DesignUI.EgoldsGoogleTextBox();
            this.tbShadow = new yt_DesignUI.EgoldsGoogleTextBox();
            this.gbPF2 = new System.Windows.Forms.GroupBox();
            this.pbPostFX2 = new System.Windows.Forms.PictureBox();
            this.tbPostFX2A = new yt_DesignUI.EgoldsGoogleTextBox();
            this.tbPostFX2B = new yt_DesignUI.EgoldsGoogleTextBox();
            this.tbPostFX2G = new yt_DesignUI.EgoldsGoogleTextBox();
            this.tbPostFX2R = new yt_DesignUI.EgoldsGoogleTextBox();
            this.gbPF1 = new System.Windows.Forms.GroupBox();
            this.tbPostFX1A = new yt_DesignUI.EgoldsGoogleTextBox();
            this.pbPostFX1 = new System.Windows.Forms.PictureBox();
            this.tbPostFX1G = new yt_DesignUI.EgoldsGoogleTextBox();
            this.tbPostFX1R = new yt_DesignUI.EgoldsGoogleTextBox();
            this.tbPostFX1B = new yt_DesignUI.EgoldsGoogleTextBox();
            this.gbAmbientObj = new System.Windows.Forms.GroupBox();
            this.pbAmbientObj = new System.Windows.Forms.PictureBox();
            this.tbAmbientObjB = new yt_DesignUI.EgoldsGoogleTextBox();
            this.tbAmbientObjG = new yt_DesignUI.EgoldsGoogleTextBox();
            this.tbAmbientObjR = new yt_DesignUI.EgoldsGoogleTextBox();
            this.gbAmbient = new System.Windows.Forms.GroupBox();
            this.pbAmbient = new System.Windows.Forms.PictureBox();
            this.tbAmbientG = new yt_DesignUI.EgoldsGoogleTextBox();
            this.tbAmbientR = new yt_DesignUI.EgoldsGoogleTextBox();
            this.tbAmbientB = new yt_DesignUI.EgoldsGoogleTextBox();
            this.tbDraw = new yt_DesignUI.EgoldsGoogleTextBox();
            this.tbLightOnGround = new yt_DesignUI.EgoldsGoogleTextBox();
            this.btnEdit = new yt_DesignUI.yt_Button();
            this.tbFog = new yt_DesignUI.EgoldsGoogleTextBox();
            this.tbSpriteBright = new yt_DesignUI.EgoldsGoogleTextBox();
            this.pnlOneSelect = new System.Windows.Forms.Panel();
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            this.tbPath = new yt_DesignUI.EgoldsGoogleTextBox();
            this.btnBrowse = new yt_DesignUI.yt_Button();
            this.btnLocalization = new yt_DesignUI.yt_Button();
            this.pnlDrawDist.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.gbPF2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPostFX2)).BeginInit();
            this.gbPF1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPostFX1)).BeginInit();
            this.gbAmbientObj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmbientObj)).BeginInit();
            this.gbAmbient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmbient)).BeginInit();
            this.pnlOneSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbWeather
            // 
            this.cbWeather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeather.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbWeather.FormattingEnabled = true;
            this.cbWeather.Items.AddRange(new object[] {
            "All",
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
            this.cbWeather.TabIndex = 3;
            this.cbWeather.SelectedIndexChanged += new System.EventHandler(this.CbWeather_SelectedIndexChanged);
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWeather.Location = new System.Drawing.Point(7, 4);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(62, 16);
            this.lblWeather.TabIndex = 1;
            this.lblWeather.Text = "Weather";
            // 
            // cbTime
            // 
            this.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "All",
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
            this.cbTime.Size = new System.Drawing.Size(143, 24);
            this.cbTime.TabIndex = 8;
            this.cbTime.SelectedIndexChanged += new System.EventHandler(this.CbTime_SelectedIndexChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(219, 2);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(38, 16);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // pnlDrawDist
            // 
            this.pnlDrawDist.Controls.Add(this.btnShow);
            this.pnlDrawDist.Controls.Add(this.tgglMultiselect);
            this.pnlDrawDist.Controls.Add(this.pnlEdit);
            this.pnlDrawDist.Controls.Add(this.pnlOneSelect);
            this.pnlDrawDist.Location = new System.Drawing.Point(1, 57);
            this.pnlDrawDist.Name = "pnlDrawDist";
            this.pnlDrawDist.Size = new System.Drawing.Size(550, 436);
            this.pnlDrawDist.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DarkCyan;
            this.btnShow.BackColorAdditional = System.Drawing.Color.Gray;
            this.btnShow.BackColorGradientEnabled = false;
            this.btnShow.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnShow.BorderColor = System.Drawing.Color.Black;
            this.btnShow.BorderColorEnabled = false;
            this.btnShow.BorderColorOnHover = System.Drawing.Color.LightSeaGreen;
            this.btnShow.BorderColorOnHoverEnabled = false;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(415, 17);
            this.btnShow.Name = "btnShow";
            this.btnShow.RippleColor = System.Drawing.Color.Black;
            this.btnShow.RoundingEnable = true;
            this.btnShow.Size = new System.Drawing.Size(130, 34);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "Show";
            this.btnShow.TextHover = null;
            this.btnShow.UseDownPressEffectOnClick = false;
            this.btnShow.UseRippleEffect = true;
            this.btnShow.UseZoomEffectOnHover = false;
            this.btnShow.Visible = false;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // tgglMultiselect
            // 
            this.tgglMultiselect.BackColor = System.Drawing.Color.White;
            this.tgglMultiselect.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.tgglMultiselect.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.tgglMultiselect.Checked = false;
            this.tgglMultiselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgglMultiselect.Font = new System.Drawing.Font("Verdana", 9F);
            this.tgglMultiselect.Location = new System.Drawing.Point(370, 27);
            this.tgglMultiselect.Name = "tgglMultiselect";
            this.tgglMultiselect.Size = new System.Drawing.Size(116, 15);
            this.tgglMultiselect.TabIndex = 12;
            this.tgglMultiselect.Text = "Multiselect";
            this.tgglMultiselect.TextOnChecked = "";
            this.tgglMultiselect.CheckedChanged += new yt_DesignUI.EgoldsToggleSwitch.OnCheckedChangedHandler(this.TgglMultiselect_CheckedChanged);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.tbPoleShading);
            this.pnlEdit.Controls.Add(this.tbLightShading);
            this.pnlEdit.Controls.Add(this.tbShadow);
            this.pnlEdit.Controls.Add(this.gbPF2);
            this.pnlEdit.Controls.Add(this.gbPF1);
            this.pnlEdit.Controls.Add(this.gbAmbientObj);
            this.pnlEdit.Controls.Add(this.gbAmbient);
            this.pnlEdit.Controls.Add(this.tbDraw);
            this.pnlEdit.Controls.Add(this.tbLightOnGround);
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.Controls.Add(this.tbFog);
            this.pnlEdit.Controls.Add(this.tbSpriteBright);
            this.pnlEdit.Location = new System.Drawing.Point(0, 53);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(550, 383);
            this.pnlEdit.TabIndex = 11;
            // 
            // tbPoleShading
            // 
            this.tbPoleShading.BackColor = System.Drawing.Color.White;
            this.tbPoleShading.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbPoleShading.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbPoleShading.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPoleShading.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPoleShading.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbPoleShading.ForeColor = System.Drawing.Color.Black;
            this.tbPoleShading.Location = new System.Drawing.Point(384, 86);
            this.tbPoleShading.Name = "tbPoleShading";
            this.tbPoleShading.SelectionStart = 0;
            this.tbPoleShading.Size = new System.Drawing.Size(160, 40);
            this.tbPoleShading.TabIndex = 20;
            this.tbPoleShading.TextInput = "";
            this.tbPoleShading.TextPreview = "Pole shading";
            this.tbPoleShading.UseSystemPasswordChar = false;
            // 
            // tbLightShading
            // 
            this.tbLightShading.BackColor = System.Drawing.Color.White;
            this.tbLightShading.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbLightShading.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbLightShading.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLightShading.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbLightShading.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbLightShading.ForeColor = System.Drawing.Color.Black;
            this.tbLightShading.Location = new System.Drawing.Point(221, 86);
            this.tbLightShading.Name = "tbLightShading";
            this.tbLightShading.SelectionStart = 0;
            this.tbLightShading.Size = new System.Drawing.Size(157, 40);
            this.tbLightShading.TabIndex = 19;
            this.tbLightShading.TextInput = "";
            this.tbLightShading.TextPreview = "Light shading";
            this.tbLightShading.UseSystemPasswordChar = false;
            // 
            // tbShadow
            // 
            this.tbShadow.BackColor = System.Drawing.Color.White;
            this.tbShadow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbShadow.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbShadow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbShadow.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbShadow.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbShadow.ForeColor = System.Drawing.Color.Black;
            this.tbShadow.Location = new System.Drawing.Point(7, 86);
            this.tbShadow.Name = "tbShadow";
            this.tbShadow.SelectionStart = 0;
            this.tbShadow.Size = new System.Drawing.Size(208, 40);
            this.tbShadow.TabIndex = 18;
            this.tbShadow.TextInput = "";
            this.tbShadow.TextPreview = "Shadow";
            this.tbShadow.UseSystemPasswordChar = false;
            // 
            // gbPF2
            // 
            this.gbPF2.Controls.Add(this.pbPostFX2);
            this.gbPF2.Controls.Add(this.tbPostFX2A);
            this.gbPF2.Controls.Add(this.tbPostFX2B);
            this.gbPF2.Controls.Add(this.tbPostFX2G);
            this.gbPF2.Controls.Add(this.tbPostFX2R);
            this.gbPF2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbPF2.Location = new System.Drawing.Point(7, 314);
            this.gbPF2.Name = "gbPF2";
            this.gbPF2.Size = new System.Drawing.Size(397, 62);
            this.gbPF2.TabIndex = 15;
            this.gbPF2.TabStop = false;
            this.gbPF2.Text = "PostFX2";
            // 
            // pbPostFX2
            // 
            this.pbPostFX2.BackColor = System.Drawing.Color.Black;
            this.pbPostFX2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPostFX2.Location = new System.Drawing.Point(268, 21);
            this.pbPostFX2.Name = "pbPostFX2";
            this.pbPostFX2.Size = new System.Drawing.Size(34, 34);
            this.pbPostFX2.TabIndex = 24;
            this.pbPostFX2.TabStop = false;
            this.pbPostFX2.BackColorChanged += new System.EventHandler(this.PbPostFX2_BackColorChanged);
            // 
            // tbPostFX2A
            // 
            this.tbPostFX2A.BackColor = System.Drawing.Color.White;
            this.tbPostFX2A.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbPostFX2A.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbPostFX2A.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPostFX2A.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPostFX2A.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbPostFX2A.ForeColor = System.Drawing.Color.Black;
            this.tbPostFX2A.Location = new System.Drawing.Point(306, 15);
            this.tbPostFX2A.Name = "tbPostFX2A";
            this.tbPostFX2A.SelectionStart = 0;
            this.tbPostFX2A.Size = new System.Drawing.Size(84, 40);
            this.tbPostFX2A.TabIndex = 9;
            this.tbPostFX2A.TextInput = "";
            this.tbPostFX2A.TextPreview = "Alpha";
            this.tbPostFX2A.UseSystemPasswordChar = false;
            // 
            // tbPostFX2B
            // 
            this.tbPostFX2B.BackColor = System.Drawing.Color.White;
            this.tbPostFX2B.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbPostFX2B.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbPostFX2B.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPostFX2B.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPostFX2B.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbPostFX2B.ForeColor = System.Drawing.Color.Black;
            this.tbPostFX2B.Location = new System.Drawing.Point(180, 15);
            this.tbPostFX2B.Name = "tbPostFX2B";
            this.tbPostFX2B.SelectionStart = 0;
            this.tbPostFX2B.Size = new System.Drawing.Size(84, 40);
            this.tbPostFX2B.TabIndex = 8;
            this.tbPostFX2B.TextInput = "";
            this.tbPostFX2B.TextPreview = "Blue";
            this.tbPostFX2B.UseSystemPasswordChar = false;
            // 
            // tbPostFX2G
            // 
            this.tbPostFX2G.BackColor = System.Drawing.Color.White;
            this.tbPostFX2G.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbPostFX2G.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbPostFX2G.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPostFX2G.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPostFX2G.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbPostFX2G.ForeColor = System.Drawing.Color.Black;
            this.tbPostFX2G.Location = new System.Drawing.Point(93, 15);
            this.tbPostFX2G.Name = "tbPostFX2G";
            this.tbPostFX2G.SelectionStart = 0;
            this.tbPostFX2G.Size = new System.Drawing.Size(84, 40);
            this.tbPostFX2G.TabIndex = 7;
            this.tbPostFX2G.TextInput = "";
            this.tbPostFX2G.TextPreview = "Green";
            this.tbPostFX2G.UseSystemPasswordChar = false;
            // 
            // tbPostFX2R
            // 
            this.tbPostFX2R.BackColor = System.Drawing.Color.White;
            this.tbPostFX2R.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbPostFX2R.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbPostFX2R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPostFX2R.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPostFX2R.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbPostFX2R.ForeColor = System.Drawing.Color.Black;
            this.tbPostFX2R.Location = new System.Drawing.Point(6, 15);
            this.tbPostFX2R.Name = "tbPostFX2R";
            this.tbPostFX2R.SelectionStart = 0;
            this.tbPostFX2R.Size = new System.Drawing.Size(84, 40);
            this.tbPostFX2R.TabIndex = 6;
            this.tbPostFX2R.TextInput = "";
            this.tbPostFX2R.TextPreview = "Red";
            this.tbPostFX2R.UseSystemPasswordChar = false;
            // 
            // gbPF1
            // 
            this.gbPF1.Controls.Add(this.tbPostFX1A);
            this.gbPF1.Controls.Add(this.pbPostFX1);
            this.gbPF1.Controls.Add(this.tbPostFX1G);
            this.gbPF1.Controls.Add(this.tbPostFX1R);
            this.gbPF1.Controls.Add(this.tbPostFX1B);
            this.gbPF1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbPF1.Location = new System.Drawing.Point(7, 252);
            this.gbPF1.Name = "gbPF1";
            this.gbPF1.Size = new System.Drawing.Size(397, 62);
            this.gbPF1.TabIndex = 14;
            this.gbPF1.TabStop = false;
            this.gbPF1.Text = "PostFX1";
            // 
            // tbPostFX1A
            // 
            this.tbPostFX1A.BackColor = System.Drawing.Color.White;
            this.tbPostFX1A.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbPostFX1A.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbPostFX1A.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPostFX1A.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPostFX1A.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbPostFX1A.ForeColor = System.Drawing.Color.Black;
            this.tbPostFX1A.Location = new System.Drawing.Point(306, 15);
            this.tbPostFX1A.Name = "tbPostFX1A";
            this.tbPostFX1A.SelectionStart = 0;
            this.tbPostFX1A.Size = new System.Drawing.Size(84, 40);
            this.tbPostFX1A.TabIndex = 9;
            this.tbPostFX1A.TextInput = "";
            this.tbPostFX1A.TextPreview = "Alpha";
            this.tbPostFX1A.UseSystemPasswordChar = false;
            // 
            // pbPostFX1
            // 
            this.pbPostFX1.BackColor = System.Drawing.Color.Black;
            this.pbPostFX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPostFX1.Location = new System.Drawing.Point(268, 21);
            this.pbPostFX1.Name = "pbPostFX1";
            this.pbPostFX1.Size = new System.Drawing.Size(34, 34);
            this.pbPostFX1.TabIndex = 23;
            this.pbPostFX1.TabStop = false;
            this.pbPostFX1.BackColorChanged += new System.EventHandler(this.PbPostFX1_BackColorChanged);
            // 
            // tbPostFX1G
            // 
            this.tbPostFX1G.BackColor = System.Drawing.Color.White;
            this.tbPostFX1G.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbPostFX1G.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbPostFX1G.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPostFX1G.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPostFX1G.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbPostFX1G.ForeColor = System.Drawing.Color.Black;
            this.tbPostFX1G.Location = new System.Drawing.Point(93, 15);
            this.tbPostFX1G.Name = "tbPostFX1G";
            this.tbPostFX1G.SelectionStart = 0;
            this.tbPostFX1G.Size = new System.Drawing.Size(84, 40);
            this.tbPostFX1G.TabIndex = 7;
            this.tbPostFX1G.TextInput = "";
            this.tbPostFX1G.TextPreview = "Green";
            this.tbPostFX1G.UseSystemPasswordChar = false;
            // 
            // tbPostFX1R
            // 
            this.tbPostFX1R.BackColor = System.Drawing.Color.White;
            this.tbPostFX1R.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbPostFX1R.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbPostFX1R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPostFX1R.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPostFX1R.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbPostFX1R.ForeColor = System.Drawing.Color.Black;
            this.tbPostFX1R.Location = new System.Drawing.Point(6, 15);
            this.tbPostFX1R.Name = "tbPostFX1R";
            this.tbPostFX1R.SelectionStart = 0;
            this.tbPostFX1R.Size = new System.Drawing.Size(84, 40);
            this.tbPostFX1R.TabIndex = 6;
            this.tbPostFX1R.TextInput = "";
            this.tbPostFX1R.TextPreview = "Red";
            this.tbPostFX1R.UseSystemPasswordChar = false;
            // 
            // tbPostFX1B
            // 
            this.tbPostFX1B.BackColor = System.Drawing.Color.White;
            this.tbPostFX1B.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbPostFX1B.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbPostFX1B.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPostFX1B.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPostFX1B.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbPostFX1B.ForeColor = System.Drawing.Color.Black;
            this.tbPostFX1B.Location = new System.Drawing.Point(180, 15);
            this.tbPostFX1B.Name = "tbPostFX1B";
            this.tbPostFX1B.SelectionStart = 0;
            this.tbPostFX1B.Size = new System.Drawing.Size(84, 40);
            this.tbPostFX1B.TabIndex = 8;
            this.tbPostFX1B.TextInput = "";
            this.tbPostFX1B.TextPreview = "Blue";
            this.tbPostFX1B.UseSystemPasswordChar = false;
            // 
            // gbAmbientObj
            // 
            this.gbAmbientObj.Controls.Add(this.pbAmbientObj);
            this.gbAmbientObj.Controls.Add(this.tbAmbientObjB);
            this.gbAmbientObj.Controls.Add(this.tbAmbientObjG);
            this.gbAmbientObj.Controls.Add(this.tbAmbientObjR);
            this.gbAmbientObj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbAmbientObj.Location = new System.Drawing.Point(7, 189);
            this.gbAmbientObj.Name = "gbAmbientObj";
            this.gbAmbientObj.Size = new System.Drawing.Size(310, 62);
            this.gbAmbientObj.TabIndex = 17;
            this.gbAmbientObj.TabStop = false;
            this.gbAmbientObj.Text = "Ambient Obj";
            // 
            // pbAmbientObj
            // 
            this.pbAmbientObj.BackColor = System.Drawing.Color.Black;
            this.pbAmbientObj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbAmbientObj.Location = new System.Drawing.Point(268, 21);
            this.pbAmbientObj.Name = "pbAmbientObj";
            this.pbAmbientObj.Size = new System.Drawing.Size(34, 34);
            this.pbAmbientObj.TabIndex = 22;
            this.pbAmbientObj.TabStop = false;
            this.pbAmbientObj.BackColorChanged += new System.EventHandler(this.PbAmbientObj_BackColorChanged);
            // 
            // tbAmbientObjB
            // 
            this.tbAmbientObjB.BackColor = System.Drawing.Color.White;
            this.tbAmbientObjB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbAmbientObjB.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbAmbientObjB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAmbientObjB.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbAmbientObjB.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbAmbientObjB.ForeColor = System.Drawing.Color.Black;
            this.tbAmbientObjB.Location = new System.Drawing.Point(180, 15);
            this.tbAmbientObjB.Name = "tbAmbientObjB";
            this.tbAmbientObjB.SelectionStart = 0;
            this.tbAmbientObjB.Size = new System.Drawing.Size(84, 40);
            this.tbAmbientObjB.TabIndex = 8;
            this.tbAmbientObjB.TextInput = "";
            this.tbAmbientObjB.TextPreview = "Blue";
            this.tbAmbientObjB.UseSystemPasswordChar = false;
            // 
            // tbAmbientObjG
            // 
            this.tbAmbientObjG.BackColor = System.Drawing.Color.White;
            this.tbAmbientObjG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbAmbientObjG.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbAmbientObjG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAmbientObjG.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbAmbientObjG.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbAmbientObjG.ForeColor = System.Drawing.Color.Black;
            this.tbAmbientObjG.Location = new System.Drawing.Point(93, 15);
            this.tbAmbientObjG.Name = "tbAmbientObjG";
            this.tbAmbientObjG.SelectionStart = 0;
            this.tbAmbientObjG.Size = new System.Drawing.Size(84, 40);
            this.tbAmbientObjG.TabIndex = 7;
            this.tbAmbientObjG.TextInput = "";
            this.tbAmbientObjG.TextPreview = "Green";
            this.tbAmbientObjG.UseSystemPasswordChar = false;
            // 
            // tbAmbientObjR
            // 
            this.tbAmbientObjR.BackColor = System.Drawing.Color.White;
            this.tbAmbientObjR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbAmbientObjR.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbAmbientObjR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAmbientObjR.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbAmbientObjR.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbAmbientObjR.ForeColor = System.Drawing.Color.Black;
            this.tbAmbientObjR.Location = new System.Drawing.Point(6, 15);
            this.tbAmbientObjR.Name = "tbAmbientObjR";
            this.tbAmbientObjR.SelectionStart = 0;
            this.tbAmbientObjR.Size = new System.Drawing.Size(84, 40);
            this.tbAmbientObjR.TabIndex = 6;
            this.tbAmbientObjR.TextInput = "";
            this.tbAmbientObjR.TextPreview = "Red";
            this.tbAmbientObjR.UseSystemPasswordChar = false;
            // 
            // gbAmbient
            // 
            this.gbAmbient.Controls.Add(this.pbAmbient);
            this.gbAmbient.Controls.Add(this.tbAmbientG);
            this.gbAmbient.Controls.Add(this.tbAmbientR);
            this.gbAmbient.Controls.Add(this.tbAmbientB);
            this.gbAmbient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbAmbient.Location = new System.Drawing.Point(7, 128);
            this.gbAmbient.Name = "gbAmbient";
            this.gbAmbient.Size = new System.Drawing.Size(310, 62);
            this.gbAmbient.TabIndex = 16;
            this.gbAmbient.TabStop = false;
            this.gbAmbient.Text = "Ambient";
            // 
            // pbAmbient
            // 
            this.pbAmbient.BackColor = System.Drawing.Color.Black;
            this.pbAmbient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbAmbient.Location = new System.Drawing.Point(268, 21);
            this.pbAmbient.Name = "pbAmbient";
            this.pbAmbient.Size = new System.Drawing.Size(34, 34);
            this.pbAmbient.TabIndex = 21;
            this.pbAmbient.TabStop = false;
            this.pbAmbient.BackColorChanged += new System.EventHandler(this.PbAmbient_BackColorChanged);
            // 
            // tbAmbientG
            // 
            this.tbAmbientG.BackColor = System.Drawing.Color.White;
            this.tbAmbientG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbAmbientG.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbAmbientG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAmbientG.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbAmbientG.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbAmbientG.ForeColor = System.Drawing.Color.Black;
            this.tbAmbientG.Location = new System.Drawing.Point(93, 15);
            this.tbAmbientG.Name = "tbAmbientG";
            this.tbAmbientG.SelectionStart = 0;
            this.tbAmbientG.Size = new System.Drawing.Size(84, 40);
            this.tbAmbientG.TabIndex = 7;
            this.tbAmbientG.TextInput = "";
            this.tbAmbientG.TextPreview = "Green";
            this.tbAmbientG.UseSystemPasswordChar = false;
            // 
            // tbAmbientR
            // 
            this.tbAmbientR.BackColor = System.Drawing.Color.White;
            this.tbAmbientR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbAmbientR.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbAmbientR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAmbientR.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbAmbientR.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbAmbientR.ForeColor = System.Drawing.Color.Black;
            this.tbAmbientR.Location = new System.Drawing.Point(6, 15);
            this.tbAmbientR.Name = "tbAmbientR";
            this.tbAmbientR.SelectionStart = 0;
            this.tbAmbientR.Size = new System.Drawing.Size(84, 40);
            this.tbAmbientR.TabIndex = 6;
            this.tbAmbientR.TextInput = "";
            this.tbAmbientR.TextPreview = "Red";
            this.tbAmbientR.UseSystemPasswordChar = false;
            // 
            // tbAmbientB
            // 
            this.tbAmbientB.BackColor = System.Drawing.Color.White;
            this.tbAmbientB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbAmbientB.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbAmbientB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAmbientB.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbAmbientB.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbAmbientB.ForeColor = System.Drawing.Color.Black;
            this.tbAmbientB.Location = new System.Drawing.Point(180, 15);
            this.tbAmbientB.Name = "tbAmbientB";
            this.tbAmbientB.SelectionStart = 0;
            this.tbAmbientB.Size = new System.Drawing.Size(84, 40);
            this.tbAmbientB.TabIndex = 8;
            this.tbAmbientB.TextInput = "";
            this.tbAmbientB.TextPreview = "Blue";
            this.tbAmbientB.UseSystemPasswordChar = false;
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
            this.tbDraw.Size = new System.Drawing.Size(208, 40);
            this.tbDraw.TabIndex = 5;
            this.tbDraw.TextInput = "";
            this.tbDraw.TextPreview = "Draw distance";
            this.tbDraw.UseSystemPasswordChar = false;
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
            this.tbLightOnGround.Location = new System.Drawing.Point(221, 43);
            this.tbLightOnGround.Name = "tbLightOnGround";
            this.tbLightOnGround.SelectionStart = 0;
            this.tbLightOnGround.Size = new System.Drawing.Size(157, 40);
            this.tbLightOnGround.TabIndex = 13;
            this.tbLightOnGround.TextInput = "";
            this.tbLightOnGround.TextPreview = "Light on ground";
            this.tbLightOnGround.UseSystemPasswordChar = false;
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
            this.btnEdit.Location = new System.Drawing.Point(415, 343);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RippleColor = System.Drawing.Color.Black;
            this.btnEdit.RoundingEnable = true;
            this.btnEdit.Size = new System.Drawing.Size(130, 33);
            this.btnEdit.TabIndex = 7;
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
            this.tbFog.Location = new System.Drawing.Point(221, 0);
            this.tbFog.Name = "tbFog";
            this.tbFog.SelectionStart = 0;
            this.tbFog.Size = new System.Drawing.Size(157, 40);
            this.tbFog.TabIndex = 9;
            this.tbFog.TextInput = "";
            this.tbFog.TextPreview = "Fog distance";
            this.tbFog.UseSystemPasswordChar = false;
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
            this.tbSpriteBright.Size = new System.Drawing.Size(208, 40);
            this.tbSpriteBright.TabIndex = 10;
            this.tbSpriteBright.TextInput = "";
            this.tbSpriteBright.TextPreview = "Sprite brightness";
            this.tbSpriteBright.UseSystemPasswordChar = false;
            // 
            // pnlOneSelect
            // 
            this.pnlOneSelect.Controls.Add(this.cbWeather);
            this.pnlOneSelect.Controls.Add(this.cbTime);
            this.pnlOneSelect.Controls.Add(this.lblTime);
            this.pnlOneSelect.Controls.Add(this.lblWeather);
            this.pnlOneSelect.Location = new System.Drawing.Point(0, 0);
            this.pnlOneSelect.Name = "pnlOneSelect";
            this.pnlOneSelect.Size = new System.Drawing.Size(364, 53);
            this.pnlOneSelect.TabIndex = 14;
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
            this.tbPath.Size = new System.Drawing.Size(402, 40);
            this.tbPath.TabIndex = 4;
            this.tbPath.TextInput = "";
            this.tbPath.TextPreview = "GTA path";
            this.tbPath.UseSystemPasswordChar = false;
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
            this.btnBrowse.Location = new System.Drawing.Point(416, 17);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.RippleColor = System.Drawing.Color.Black;
            this.btnBrowse.RoundingEnable = true;
            this.btnBrowse.Size = new System.Drawing.Size(87, 34);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextHover = null;
            this.btnBrowse.UseDownPressEffectOnClick = false;
            this.btnBrowse.UseRippleEffect = true;
            this.btnBrowse.UseZoomEffectOnHover = false;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnLocalization
            // 
            this.btnLocalization.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLocalization.BackColorAdditional = System.Drawing.Color.Gray;
            this.btnLocalization.BackColorGradientEnabled = false;
            this.btnLocalization.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnLocalization.BorderColor = System.Drawing.Color.Black;
            this.btnLocalization.BorderColorEnabled = false;
            this.btnLocalization.BorderColorOnHover = System.Drawing.Color.LightSeaGreen;
            this.btnLocalization.BorderColorOnHoverEnabled = false;
            this.btnLocalization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalization.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLocalization.ForeColor = System.Drawing.Color.White;
            this.btnLocalization.Location = new System.Drawing.Point(508, 17);
            this.btnLocalization.Name = "btnLocalization";
            this.btnLocalization.RippleColor = System.Drawing.Color.Black;
            this.btnLocalization.RoundingEnable = true;
            this.btnLocalization.Size = new System.Drawing.Size(38, 34);
            this.btnLocalization.TabIndex = 14;
            this.btnLocalization.Text = "RUS";
            this.btnLocalization.TextHover = null;
            this.btnLocalization.UseDownPressEffectOnClick = false;
            this.btnLocalization.UseRippleEffect = true;
            this.btnLocalization.UseZoomEffectOnHover = false;
            this.btnLocalization.Click += new System.EventHandler(this.BtnLocalization_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 495);
            this.Controls.Add(this.btnLocalization);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pnlDrawDist);
            this.Controls.Add(this.tbPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(552, 533);
            this.MinimumSize = new System.Drawing.Size(552, 533);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HBM Timecyc Editor";
            this.pnlDrawDist.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.gbPF2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPostFX2)).EndInit();
            this.gbPF1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPostFX1)).EndInit();
            this.gbAmbientObj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAmbientObj)).EndInit();
            this.gbAmbient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAmbient)).EndInit();
            this.pnlOneSelect.ResumeLayout(false);
            this.pnlOneSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWeather;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.Label lblTime;
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
        private yt_DesignUI.yt_Button btnShow;
        public yt_DesignUI.EgoldsToggleSwitch tgglMultiselect;
        private yt_DesignUI.yt_Button btnLocalization;
        private System.Windows.Forms.GroupBox gbPF2;
        private yt_DesignUI.EgoldsGoogleTextBox tbPostFX2B;
        private yt_DesignUI.EgoldsGoogleTextBox tbPostFX2G;
        private yt_DesignUI.EgoldsGoogleTextBox tbPostFX2R;
        private System.Windows.Forms.GroupBox gbPF1;
        private yt_DesignUI.EgoldsGoogleTextBox tbPostFX1B;
        private yt_DesignUI.EgoldsGoogleTextBox tbPostFX1G;
        private yt_DesignUI.EgoldsGoogleTextBox tbPostFX1R;
        private System.Windows.Forms.GroupBox gbAmbientObj;
        private yt_DesignUI.EgoldsGoogleTextBox tbAmbientObjB;
        private yt_DesignUI.EgoldsGoogleTextBox tbAmbientObjG;
        private yt_DesignUI.EgoldsGoogleTextBox tbAmbientObjR;
        private System.Windows.Forms.GroupBox gbAmbient;
        private yt_DesignUI.EgoldsGoogleTextBox tbAmbientG;
        private yt_DesignUI.EgoldsGoogleTextBox tbAmbientR;
        private yt_DesignUI.EgoldsGoogleTextBox tbAmbientB;
        private yt_DesignUI.EgoldsGoogleTextBox tbPostFX2A;
        private yt_DesignUI.EgoldsGoogleTextBox tbPostFX1A;
        private yt_DesignUI.EgoldsGoogleTextBox tbPoleShading;
        private yt_DesignUI.EgoldsGoogleTextBox tbLightShading;
        private yt_DesignUI.EgoldsGoogleTextBox tbShadow;
        private System.Windows.Forms.PictureBox pbPostFX2;
        private System.Windows.Forms.PictureBox pbPostFX1;
        private System.Windows.Forms.PictureBox pbAmbientObj;
        private System.Windows.Forms.PictureBox pbAmbient;
    }
}

