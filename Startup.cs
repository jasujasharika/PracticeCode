using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NHibernate.Cfg;

namespace PocoConfiguration
{
    /*
     * Do not change the structure of this class
     */
    public partial class Startup
    {
        private IConfiguration _config;
        //private

        public Startup(IConfiguration config)
        {
            /*
             * Use this injected configuration
             */
            config = _config;

        }

        public void ConfigureServices(IServiceCollection services)
        {
            /*
             * Register configuration here
             */
            IWebHostBuilder builder;
             services.Configure<Config>(_config.GetSection("AppSettings"));
            
            services.AddMvc();
            //ConfigurationRegistrar.RegisterAppConfiguration(Host.contex, _config);
    


        }
    }
}