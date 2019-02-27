using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPlatformRestClientInC
{
    class InformationsOfServerDTO
    {
        #region SINGLETON
        private InformationsOfServerDTO()
        {

        }

        private static InformationsOfServerDTO instance = null;

        public static InformationsOfServerDTO getInstance()
        {
            if (Instance == null)
            {
                Instance = new InformationsOfServerDTO();
            }
            return Instance;
        }
        #endregion

        #region FIELDS AND ENCAPSULATIONS
        private static string host;
        private static string port;
        private static string userName;
        private static string password;
        private static string clientToken;
        private static string firmNo;
        private static string language;
        private static string authToken;

        public static string Host { get => host; set => host = value; }
        public static string Port { get => port; set => port = value; }
        public static string UserName { get => userName; set => userName = value; }
        public static string Password { get => password; set => password = value; }
        public static string ClientToken { get => clientToken; set => clientToken = value; }
        public static string FirmNo { get => firmNo; set => firmNo = value; }
        public static string Language { get => language; set => language = value; }
        public static string AuthToken { get => authToken; set => authToken = value; }
        public static InformationsOfServerDTO Instance { get => instance; set => instance = value; }
        #endregion
    }
}
