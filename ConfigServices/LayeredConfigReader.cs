using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigServices
{
    //可覆盖配置读取器
    class LayeredConfigReader : IConfigReader
    {
        private readonly IEnumerable<IConfigService> services;

        public LayeredConfigReader(IEnumerable<IConfigService> services)
        {
            this.services = services;
        }

        public string GetValue(string name)
        {
            string value = null;
            foreach (var service in services)
            {
                string newValue = service.GetValue(name);
                if (newValue != null)
                {
                    value = newValue;
                }
            }
            return value;
        }
    }
}
