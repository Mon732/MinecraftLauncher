using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    public class AuthPayload
    {
        public struct Agent
        {
            public string name;
            public int version;
        }

        public Agent agent;
        public string username;
        public string password;
        public string clientToken;
    }
}
