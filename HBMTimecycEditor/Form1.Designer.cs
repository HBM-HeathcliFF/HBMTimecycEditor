
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.weatherCB = new System.Windows.Forms.ComboBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.drawTB = new System.Windows.Forms.TextBox();
            this.timeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pathTB = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.DDpanel = new System.Windows.Forms.Panel();
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
            this.weatherCB.TabIndex = 0;
            this.weatherCB.SelectedIndexChanged += new System.EventHandler(this.WeatherCB_SelectedIndexChanged);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBtn.Location = new System.Drawing.Point(312, 55);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(68, 23);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weather";
            // 
            // drawTB
            // 
            this.drawTB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawTB.Location = new System.Drawing.Point(312, 26);
            this.drawTB.Name = "drawTB";
            this.drawTB.Size = new System.Drawing.Size(68, 23);
            this.drawTB.TabIndex = 3;
            this.drawTB.TextChanged += new System.EventHandler(this.DrawTB_TextChanged);
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
            this.timeCB.TabIndex = 4;
            this.timeCB.SelectedIndexChanged += new System.EventHandler(this.TimeCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(220, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(312, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Draw dist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "GTA path:";
            // 
            // pathTB
            // 
            this.pathTB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathTB.Location = new System.Drawing.Point(9, 28);
            this.pathTB.Name = "pathTB";
            this.pathTB.Size = new System.Drawing.Size(298, 23);
            this.pathTB.TabIndex = 8;
            this.pathTB.TextChanged += new System.EventHandler(this.PathTB_TextChanged);
            // 
            // browseBtn
            // 
            this.browseBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseBtn.Location = new System.Drawing.Point(313, 28);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(68, 23);
            this.browseBtn.TabIndex = 9;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // DDpanel
            // 
            this.DDpanel.Controls.Add(this.drawTB);
            this.DDpanel.Controls.Add(this.weatherCB);
            this.DDpanel.Controls.Add(this.editBtn);
            this.DDpanel.Controls.Add(this.label3);
            this.DDpanel.Controls.Add(this.label1);
            this.DDpanel.Controls.Add(this.label2);
            this.DDpanel.Controls.Add(this.timeCB);
            this.DDpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DDpanel.Location = new System.Drawing.Point(0, 57);
            this.DDpanel.Name = "DDpanel";
            this.DDpanel.Size = new System.Drawing.Size(389, 84);
            this.DDpanel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 141);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pathTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DDpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(405, 179);
            this.MinimumSize = new System.Drawing.Size(405, 179);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HBM Draw distance editor";
            this.DDpanel.ResumeLayout(false);
            this.DDpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox weatherCB;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox drawTB;
        private System.Windows.Forms.ComboBox timeCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pathTB;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Panel DDpanel;
    }
}

