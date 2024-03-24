using ConfigServices;
using LogServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailServices
{
    class MailService : IMailService
    {
        //private readonly IConfigService config;
        private readonly IConfigReader config;
        private readonly ILogProvider log;

        public MailService(IConfigReader config, ILogProvider log)
        {
            this.config = config;
            this.log = log;
        }
        public void Send(string title, string to, string body)
        {
            this.log.Log("开始发送邮件!");
            string smtpServer = this.config.GetValue("SmtpServer");
            string userName = this.config.GetValue("UserName");
            string pwd = this.config.GetValue("PassWord");
            Console.WriteLine($"邮件服务器地址{smtpServer},{userName},{pwd}");
            Console.WriteLine($"真发邮件啦！----发送{title}到{to}给{body}了...");
            this.log.Log("发送邮件完成.");
        }
    }
}
