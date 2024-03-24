using System;
using System.Collections.Generic;
using System.Text;

namespace LogServices
{
    class ConsoleLogProvider : ILogProvider
    {
        public void Log(string msg)
        {
            Console.WriteLine($"打印：{msg}");
        }

        public void LogError(string msg)
        {
            Console.WriteLine($"Error!{msg}");
        }
    }
}
