using System;
using System.Collections.Generic;
using System.Text;
using MailServices;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MailServicesExtensions
    {
        public static void AddMail(this IServiceCollection services)
        {
            services.AddScoped<IMailService, MailService>();
        }
    }
}
