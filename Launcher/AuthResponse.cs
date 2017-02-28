using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    public class AuthResponse
    {
        public struct Profile
        {
            public string id;
            public string name;
            public bool legacy;
        }

        public string accesstoken;
        public string clientToken;
        public Profile[] availableProfiles;
        public Profile selectedProfile;
    }
}