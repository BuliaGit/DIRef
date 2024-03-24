using ConfigServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigServicesExtensions
    {
        public static void AddEnvVarConfig(this IServiceCollection services)
        {
            services.AddScoped<IConfigService, EnvVarConfigService>();
        }
        public static void AddIniFileConfig(this IServiceCollection services, string filePath)
        {
            services.AddScoped(typeof(IConfigService), e => new IniFileConfigService { FilePath = filePath });
        }
        public static void AddLayerConfigReader(this IServiceCollection services)
        {
            services.AddScoped<IConfigReader, LayeredConfigReader>();
        }
    }
}
