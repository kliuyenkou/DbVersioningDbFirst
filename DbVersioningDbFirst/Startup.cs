using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DbVersioningDbFirst.Startup))]
namespace DbVersioningDbFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
