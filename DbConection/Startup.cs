using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DbConection.Startup))]
namespace DbConection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
