using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace HVHelper
{
    public class ConfigReader : IConfig
    {
        public string GetUserName()
        {
            return ConfigurationManager.AppSettings[ConfgiKeys.UserName];
        }
        public string GetEnvironmentLink()
        {
            return ConfigurationManager.AppSettings[ConfgiKeys.EnvironmentURL];
        }
    }
}
