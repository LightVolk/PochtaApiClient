using System;
using System.Collections.Generic;
using System.Text;

namespace PochtaApiClient
{
    /// <summary>
    /// сделать чтение логина и пароля из конфига
    /// </summary>
    public class Config
    {
        public Config()
        {

        }

        public AuthorizationHeader GetAuthorizationHeader()
        {
            return new AuthorizationHeader()
            {
                login = "MUBQuiFwngQufO",
                mustUnderstand = "1",
                password = "5XkWkHOfjgqN"
            };
        }
    }
}
