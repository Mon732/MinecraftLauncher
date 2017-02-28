using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            if (Config.parameters != "" || Config.parameters == txtbxParameters.Text)
            {
                txtbxParameters.Text = Config.parameters;
            }

            if (Config.memory != "" || Config.memory == txtbxMemory.Text)
            {
                txtbxMemory.Text = Config.memory;
            }
        }

        private void frmConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.parameters = txtbxParameters.Text;
            Config.memory = txtbxMemory.Text;
        }

        private void ckbxNukeFiles_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbxNukeFiles.Checked)
            {
                btnNukeFiles.Enabled = true;
            }
            else
            {
                btnNukeFiles.Enabled = false;
            }
        }

        private void btnNukeFiles_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This will delete your install of Dragonlands, are you sure you want to?", "Delete Files?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DownloadManager.cancelDownload();
                Directory.Delete(Config.directory, true);
                Application.Exit();
            }
        }
    }
}
