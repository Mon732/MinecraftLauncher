using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    public class VersionsJSON
    {
        public struct Library
        {
            public struct Rules
            {
                public struct OS
                {
                    public string name;
                    public string version;
                }

                public string action;
                public OS os;
            }

            public struct Natives
            {
                public string linux;
                public string windows;
                public string osx;
            }

            public struct Extract
            {
                public string[] exclude;
            }

            public string name;
            public string url;
            public Rules[] rules;
            public Natives natives;
            public Extract extract;
            public string serverreq;
        }

        public string id;
        public string time;
        public string releaseTime;
        public string type;
        public string minecraftArguments;
        public Library[] libraries;
        public string mainClass;
        public int minimumLauncherVersion;
        public string assets;
    }
}
