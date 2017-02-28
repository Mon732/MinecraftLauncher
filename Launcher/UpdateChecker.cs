using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    static class UpdateChecker
    {
        public static void checkforUpdates()
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.DownloadFile(Config.downloadUrl + "version", Config.launcherFolder + @"\version");
                }
                catch (WebException)
                {
                    frmLauncher.messageBox("Unable to download version file");
                    return;
                }
            }

            string versionNumber;

            using (StreamReader version = new StreamReader(Config.launcherFolder + @"\version"))
            {
                versionNumber = version.ReadToEnd();
            }

            if (versionNumber != Config.launcherVersion)
            {
                using (WebClient webClient = new WebClient())
                {
                    try
                    {
                        webClient.DownloadFile(Config.downloadUrl + "Updater.exe", Config.launcherFolder + @"\Updater.exe");
                    }
                    catch (WebException)
                    {
                        frmLauncher.messageBox("Unable to download Updater\n");
                        return;
                    }
                }

                frmLauncher.messageBox("Update Required");
                Process.Start(Config.launcherFolder + @"\Updater.exe");
                frmLauncher.quitLauncher();
            }
        }
    }
}