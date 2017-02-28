namespace Launcher
{
    partial class frmConfig
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
            this.ckbxNukeFiles = new System.Windows.Forms.CheckBox();
            this.btnNukeFiles = new System.Windows.Forms.Button();
            this.txtbxParameters = new System.Windows.Forms.TextBox();
            this.txtbxMemory = new System.Windows.Forms.TextBox();
            this.lblParameters = new System.Windows.Forms.Label();
            this.lblMemory = new System.Windows.Forms.Label();
            this.lblMemoryUnits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckbxNukeFiles
            // 
            this.ckbxNukeFiles.AutoSize = true;
            this.ckbxNukeFiles.Location = new System.Drawing.Point(12, 115);
            this.ckbxNukeFiles.Name = "ckbxNukeFiles";
            this.ckbxNukeFiles.Size = new System.Drawing.Size(76, 17);
            this.ckbxNukeFiles.TabIndex = 0;
            this.ckbxNukeFiles.Text = "Nuke Files";
            this.ckbxNukeFiles.UseVisualStyleBackColor = true;
            this.ckbxNukeFiles.CheckedChanged += new System.EventHandler(this.ckbxNukeFiles_CheckedChanged);
            // 
            // btnNukeFiles
            // 
            this.btnNukeFiles.Enabled = false;
            this.btnNukeFiles.Location = new System.Drawing.Point(12, 138);
            this.btnNukeFiles.Name = "btnNukeFiles";
            this.btnNukeFiles.Size = new System.Drawing.Size(75, 23);
            this.btnNukeFiles.TabIndex = 1;
            this.btnNukeFiles.Text = "Start Nuke";
            this.btnNukeFiles.UseVisualStyleBackColor = true;
            this.btnNukeFiles.Click += new System.EventHandler(this.btnNukeFiles_Click);
            // 
            // txtbxParameters
            // 
            this.txtbxParameters.Location = new System.Drawing.Point(13, 13);
            this.txtbxParameters.Name = "txtbxParameters";
            this.txtbxParameters.Size = new System.Drawing.Size(150, 20);
            this.txtbxParameters.TabIndex = 2;
            this.txtbxParameters.Text = "-XX:-UseGCOverheadLimit";
            // 
            // txtbxMemory
            // 
            this.txtbxMemory.Location = new System.Drawing.Point(13, 39);
            this.txtbxMemory.Name = "txtbxMemory";
            this.txtbxMemory.Size = new System.Drawing.Size(127, 20);
            this.txtbxMemory.TabIndex = 3;
            this.txtbxMemory.Text = "1536";
            // 
            // lblParameters
            // 
            this.lblParameters.AutoSize = true;
            this.lblParameters.Location = new System.Drawing.Point(169, 16);
            this.lblParameters.Name = "lblParameters";
            this.lblParameters.Size = new System.Drawing.Size(109, 13);
            this.lblParameters.TabIndex = 4;
            this.lblParameters.Text = "Additional Parameters";
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new System.Drawing.Point(169, 42);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(91, 13);
            this.lblMemory.TabIndex = 5;
            this.lblMemory.Text = "Allocated Memory";
            // 
            // lblMemoryUnits
            // 
            this.lblMemoryUnits.AutoSize = true;
            this.lblMemoryUnits.Location = new System.Drawing.Point(140, 42);
            this.lblMemoryUnits.Name = "lblMemoryUnits";
            this.lblMemoryUnits.Size = new System.Drawing.Size(23, 13);
            this.lblMemoryUnits.TabIndex = 6;
            this.lblMemoryUnits.Text = "MB";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 173);
            this.Controls.Add(this.lblMemoryUnits);
            this.Controls.Add(this.lblMemory);
            this.Controls.Add(this.lblParameters);
            this.Controls.Add(this.txtbxMemory);
            this.Controls.Add(this.txtbxParameters);
            this.Controls.Add(this.btnNukeFiles);
            this.Controls.Add(this.ckbxNukeFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConfig_FormClosing);
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbxNukeFiles;
        private System.Windows.Forms.Button btnNukeFiles;
        private System.Windows.Forms.TextBox txtbxParameters;
        private System.Windows.Forms.TextBox txtbxMemory;
        private System.Windows.Forms.Label lblParameters;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Label lblMemoryUnits;
    }
}