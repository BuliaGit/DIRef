using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigServices
{
    class EnvVarConfigService : IConfigService
    {
        public string GetValue(string name)
        {
            return Environment.GetEnvironmentVariable(name);
        }
    }
}
