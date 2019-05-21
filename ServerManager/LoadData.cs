using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerManager
{
    public class LoadData
    {
        // Daten die gespeichert werden sollen
        private string steamPath;
        private string steamuser;
        private string steampass;
        private string serverPath;

        // -----------------------------------
        // Speichervorgang

        public string SteamPath
        {
            get { return steamPath }
            set { steamPath = value }
        }
        // ------------------------------------
        public string SteamUser
        {
            get { return steamuser }
            set { steamuser = value }
        }
        // ------------------------------------
        public string SteamPass
        {
            get { return steampass }
            set { steampass = value }
        }
        // ------------------------------------
        public string ServerPath
        {
            get { return serverPath }
            set { serverPath = value }
        }
        // ------------------------------------

    }
}
