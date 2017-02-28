using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class frmLauncher : Form
    {
        //Variable kept to check if visible, could use bool
        frmConfig configForm;
        int fileCount = 0;
        int filesExtracted = 0;

        public frmLauncher()
        {
            InitializeComponent();
        }

        private void frmLauncher_Load(object sender, EventArgs e)
        {
            DownloadManager.setProgressBar(prgDownload);
            lblVersionNumber.Text = Config.launcherVersion;

            launcherInit();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dragin.plus.com:8123");
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            authenticate(txtbxUsername.Text, txtbxPassword.Text);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (configForm == null || configForm.IsDisposed)
            {
                configForm = new frmConfig();
                configForm.Location = new Point(this.Location.X + (this.Size.Width / 2) - (configForm.Size.Width / 2), this.Location.Y + (this.Size.Height / 2) - (configForm.Size.Height / 2));
            }

            if (!configForm.Visible)
            {
                configForm.Show();
            }
        }

        public void launcherInit()
        {
            if (!Directory.Exists(Config.launcherFolder))
            {
                Directory.CreateDirectory(Config.launcherFolder);
            }

            StreamWriter configFile = new StreamWriter(Config.launcherFolder + @"\config.cfg");
            string path = "ExeLocation|" + Application.ExecutablePath;
            configFile.WriteLine(path);
            configFile.Close();
            
            UpdateChecker.checkforUpdates();

            updateFiles();
        }

        public void updateFiles()
        {
            //Download checksum
            DownloadManager.queueDownload(Config.downloadUrl + "checksum", Config.launcherFolder + @"\checksum", updateModPack);
            DownloadManager.processDownload();
        }

        void updateModPack(object arg)
        {
            using (StreamReader checksumFile = new StreamReader(Config.launcherFolder + @"\checksum"))
            {
                string line;

                while ((line = checksumFile.ReadLine()) != null)
                {
                    fileCount += 1;

                    Char[] sep = { '|' };
                    string[] splitName = line.Split(sep);
                    string fileName = Config.launcherFolder + @"\" + splitName[0];
                    //string checksum = getChecksum(Config.launcherFolder + @"\" + splitName[0]);

                    if (!File.Exists(fileName))// || checksum != splitName[1])
                    {
                        DownloadManager.queueDownload(Config.downloadUrl + splitName[0], fileName, extractZip, (object)fileName);
                    }
                    else if (getChecksum(Config.launcherFolder + @"\" + splitName[0]) != splitName[1])
                    {
                        DownloadManager.queueDownload(Config.downloadUrl + splitName[0], fileName, extractZip, (object)fileName);
                    }
                    //else
                    //{
                    //    extractZip((object)fileName);
                    //}
                }
            }

            DownloadManager.processDownload();
        }

        void extractZip(object arg)
        {
            new Thread(delegate()
            {
                string zipPath = (string)arg;
                //MessageBox.Show(zipPath);

                using (ZipArchive archive = ZipFile.OpenRead(zipPath))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        string fileName = Path.Combine(Config.directory, entry.FullName);
                        string directory = Path.GetDirectoryName(fileName);

                        if (entry.Name == "")
                        {
                            Directory.CreateDirectory(directory);
                            continue;
                        }

                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                        }

                        entry.ExtractToFile(fileName, true);
                    }
                }   
            }).Start();

            filesExtracted += 1;

            if (filesExtracted >= fileCount)
            {
                btnLogIn.Enabled = true;
            }
        }

        public string getChecksum(string fileName)
        {
            byte[] data;
            string hashString = "";

            data = File.ReadAllBytes(fileName);

            using (MD5 md5Hash = MD5.Create())
            {
                byte[] hash = md5Hash.ComputeHash(data);

                for (int i = 0; i < hash.Length; i++)
                {
                    hashString += hash[i].ToString("x2"); //2 hex digits
                }
            }

            return hashString;
        }

        public void authenticate(string username, string password)
        {
            AuthPayload data = new AuthPayload();

            data.agent.name = "minecraft";
            data.agent.version = 1;
            data.username = username;
            data.password = password;
            data.clientToken = Config.clientToken;

            string dataSerialized = JsonConvert.SerializeObject(data);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Config.authUrl);
            request.ContentType = "application/json";
            request.Method = "POST";

            StreamWriter requestWriter = new StreamWriter(request.GetRequestStream());
            requestWriter.Write(dataSerialized);
            requestWriter.Close();
            
            try
            {
                WebResponse webResponse = request.GetResponse();
                Stream webStream = webResponse.GetResponseStream();
                StreamReader responseReader = new StreamReader(webStream);
                string response = responseReader.ReadToEnd();
                responseReader.Close();

                //MessageBox.Show(response);

                AuthResponse authResponse = JsonConvert.DeserializeObject<AuthResponse>(response);

                Config.accessToken = authResponse.accesstoken;
                Config.clientToken = authResponse.clientToken;
                Config.uuid = authResponse.selectedProfile.id;
                Config.username = authResponse.selectedProfile.name;

                launchMinecraft();
            }
            catch (WebException we)
            {
                string webExceptionMessage = we.Message;
                MessageBox.Show("Incorrect Username or Password");
            }
            
        }

        public void launchMinecraft()
        {
            StreamReader sr = new StreamReader(Config.versions + @"\" + Config.minecraftVersion + @"\" + Config.minecraftVersion + ".json");
            string text = sr.ReadToEnd();

            VersionsJSON version1710 = JsonConvert.DeserializeObject<VersionsJSON>(text);

            sr = new StreamReader(Config.versions + @"\" + Config.forgeVersion + @"\" + Config.forgeVersion + ".json");
            text = sr.ReadToEnd();

            VersionsJSON versionForge = JsonConvert.DeserializeObject<VersionsJSON>(text);

            sr.Close();

            string args = "/c ";
            args += "cd \"" + Config.directory + "\" & ";
            args += "java ";
            args += Config.parameters + " ";
            args += "-Xmx" + Config.memory + "m ";
            args += "-Xms" + Config.memory + "m ";
            args += "-Djava.library.path=\"" + Config.natives + "\" ";
            args += "-cp ";
            //args += "-cp \"";

            //net.minecraftforge:forge:1.7.10-10.13.3.1388-1.7.10
            //net minecraftforge forge 1.7.10-10.13.3.1388-1.7.10
            //forge-1.7.10-10.13.3.1388-1.7.10.jar

            //build libraries
            foreach (VersionsJSON.Library lib in versionForge.libraries)
            {
                string name = getLibraryPath(lib);

                args += "\"" + Config.libraries + @"\" + name + "\";";
            }

            foreach (VersionsJSON.Library lib in version1710.libraries)
            {
                string name = getLibraryPath(lib);

                args += "\"" + Config.libraries + @"\" + name + "\";";
            }

            args += "\"" + Config.versions + @"\" + Config.minecraftVersion + @"\" + Config.minecraftVersion + ".jar\" ";

            //args += "\" ";

            args += versionForge.mainClass + " ";

            args += "--username " + Config.username + " ";
            args += "--version " + Config.minecraftVersion + " ";
            args += "--gameDir \"" + Config.directory + "\" ";
            args += "--assetsDir \"" + Config.assets + "\" ";
            args += "--assetIndex " + Config.minecraftVersion + " ";
            args += "--uuid " + Config.uuid + " ";
            args += "--accessToken " + Config.accessToken + " ";
            args += "--userProperties " + Config.userProperties + " ";
            args += "--userType " + Config.userType + " ";
            args += "--tweakClass cpw.mods.fml.common.launcher.FMLTweaker";
            

            //MessageBox.Show(args);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = args;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();

            //Process.Start("cmd.exe", args);
        }

        string getLibraryPath(VersionsJSON.Library lib)
        {
            string[] nameSplitColon = lib.name.Split(':');
            string[] nameSplitDot = nameSplitColon[0].Split('.');

            string nameJoined = "";

            //foreach (string namePart in nameSplitDot)
            for (int i = 0; i < nameSplitDot.Count(); i++)
            {
                nameJoined += nameSplitDot[i] + @"\";
            }

            //foreach (string namePart in nameSplitColon)
            for (int i = 1; i < nameSplitColon.Count(); i++)
            {
                nameJoined += nameSplitColon[i] + @"\";
            }

            int count = nameSplitColon.Count();
            nameJoined += nameSplitColon[count - 2] + "-" + nameSplitColon[count - 1];

            if (nameJoined.Contains("platform"))
            {
                nameJoined += "-natives-windows";
            }

            if (nameJoined.Contains("twitch-platform-5.16-natives-windows")||nameJoined.Contains("twitch-external-platform-4.5-natives-windows"))
            {
                nameJoined += "-64";
            }

            nameJoined += ".jar";

            return nameJoined;


            /*
            if (jarFile.Contains("platform"))
                jarFile = jarFile.Substring(0, jarFile.Length - 4) + "-natives-windows" + ".jar";
            if (jarFile.Contains("twitch-platform-5.12-natives-windows") || jarFile.Contains("twitch-external-platform-4.5-natives-windows"))
                jarFile = jarFile.Substring(0, jarFile.Length - 4) + "-64" + ".jar";
            */

        }

        public static void messageBox(string message)
        {
            MessageBox.Show(message);
        }

        public static void quitLauncher()
        {
            Application.Exit();
        }
    }
}
