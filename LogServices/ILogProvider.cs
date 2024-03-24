using System;
using System.Collections.Generic;
using System.Text;

namespace LogServices
{
    public interface ILogProvider
    {
        public void LogError(string msg);
        public void Log(string msg);
    }
}
