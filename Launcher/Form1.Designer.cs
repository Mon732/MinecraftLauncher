namespace Launcher
{
    partial class frmLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLauncher));
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnMap = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblVersionNumber = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.btnRules = new System.Windows.Forms.Button();
            this.lblRules = new System.Windows.Forms.Label();
            this.prgDownload = new System.Windows.Forms.ProgressBar();
            this.btnConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.Enabled = false;
            this.btnLogIn.Location = new System.Drawing.Point(572, 366);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(130, 25);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(572, 309);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(130, 20);
            this.txtbxPassword.TabIndex = 1;
            this.txtbxPassword.UseSystemPasswordChar = true;
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Location = new System.Drawing.Point(572, 283);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(130, 20);
            this.txtbxUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Location = new System.Drawing.Point(513, 286);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Location = new System.Drawing.Point(513, 312);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // btnMap
            // 
            this.btnMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMap.BackgroundImage")));
            this.btnMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMap.Location = new System.Drawing.Point(600, 12);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(100, 100);
            this.btnMap.TabIndex = 5;
            this.btnMap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnMap.UseCompatibleTextRendering = true;
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Location = new System.Drawing.Point(12, 378);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 13);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "Version:";
            // 
            // lblVersionNumber
            // 
            this.lblVersionNumber.AutoSize = true;
            this.lblVersionNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblVersionNumber.Location = new System.Drawing.Point(54, 378);
            this.lblVersionNumber.Name = "lblVersionNumber";
            this.lblVersionNumber.Size = new System.Drawing.Size(65, 13);
            this.lblVersionNumber.TabIndex = 7;
            this.lblVersionNumber.Text = "Pre-Release";
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.BackColor = System.Drawing.Color.Transparent;
            this.lblMap.Location = new System.Drawing.Point(614, 115);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(75, 13);
            this.lblMap.TabIndex = 8;
            this.lblMap.Text = "Open Dynmap";
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.Transparent;
            this.btnRules.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRules.BackgroundImage")));
            this.btnRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRules.Location = new System.Drawing.Point(494, 12);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(100, 100);
            this.btnRules.TabIndex = 4;
            this.btnRules.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRules.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRules.UseCompatibleTextRendering = true;
            this.btnRules.UseVisualStyleBackColor = false;
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.BackColor = System.Drawing.Color.Transparent;
            this.lblRules.Location = new System.Drawing.Point(491, 115);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(110, 13);
            this.lblRules.TabIndex = 10;
            this.lblRules.Text = "Rules and Information";
            // 
            // prgDownload
            // 
            this.prgDownload.Location = new System.Drawing.Point(572, 335);
            this.prgDownload.Name = "prgDownload";
            this.prgDownload.Size = new System.Drawing.Size(130, 25);
            this.prgDownload.TabIndex = 11;
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(491, 366);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 25);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // frmLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 392);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.prgDownload);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.lblVersionNumber);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtbxUsername);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.btnLogIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 430);
            this.MinimumSize = new System.Drawing.Size(720, 430);
            this.Name = "frmLauncher";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "#DragonLands";
            this.Load += new System.EventHandler(this.frmLauncher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblVersionNumber;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.ProgressBar prgDownload;
        private System.Windows.Forms.Button btnConfig;
    }
}

