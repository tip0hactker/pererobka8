using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pererobka8
{
    public class ConfigurationManager
    {
        private static ConfigurationManager _instance;

        private Dictionary<string, string> _settings;

        private ConfigurationManager()
        {
            _settings = new Dictionary<string, string>();
        }

        public static ConfigurationManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigurationManager();
                }

                return _instance;
            }
        }

        public string GetSetting(string key)
        {
            if (!_settings.ContainsKey(key))
            {
                return null;
            }

            return _settings[key];
        }

        public void SetSetting(string key, string value)
        {
            _settings[key] = value;
        }
    }
}