using System;
using System.IO;
using System.Linq;
using MailServices;
using Microsoft.Extensions.DependencyInjection;

namespace MailServicesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            //环境变量配置读取
            services.AddEnvVarConfig();
            //ini文件读取
            services.AddIniFileConfig(@"D:\MyProgram\C#StudyTemplate\DIRef\MailServicesConsole\mail.ini");
            //注册覆盖读取器
            services.AddLayerConfigReader();

            services.AddConsoleLog();
            services.AddMail();
            using (var sp = services.BuildServiceProvider())
            {
                var mail = sp.GetRequiredService<IMailService>();
                mail.Send("3月13邮件", "二仙桥", "某某某");
            }

        }
    }
}
