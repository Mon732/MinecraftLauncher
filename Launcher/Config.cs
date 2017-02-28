using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    public static class Config
    {
        //Versions
        public static string launcherVersion = "1.0.0.1";
        public static string minecraftVersion = "1.7.10";
        public static string forgeVersion = "1.7.10-Forge10.13.3.1388-1.7.10";
        
        //Paths
        public static string appdata = Environment.GetEnvironmentVariable("appdata");
        public static string java = Environment.GetEnvironmentVariable("java_home") + @"\bin\java";
        public static string directory = appdata + @"\DragonLands";
        public static string assets = directory + @"\assets";
        public static string natives = appdata + @"\DragonLands\versions\" + forgeVersion + @"\" + forgeVersion + @"-natives";
        public static string libraries = directory + @"\libraries";
        public static string versions = directory + @"\versions";
        public static string launcherFolder = directory + @"\launcher";

        //Tokens
        public static string clientToken = "d0f8fce58a604a8ba482012826beb21c";
        public static string accessToken = "";
        public static string uuid = "";

        //URLs
        public static string authUrl = @"https://authserver.mojang.com/authenticate";
        public static string downloadUrl = @"https://dl.dropboxusercontent.com/u/8779072/DragonLands/";

        //Args
        public static string parameters = "-XX:-UseGCOverheadLimit";
        public static string memory = "1536";

        //Userdetails
        public static string username = "";
        public static string userProperties = "{}";
        public static string userType = "mojang";
    }
}
