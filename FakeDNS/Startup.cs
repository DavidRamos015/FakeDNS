using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FakeDNS.Startup))]
namespace FakeDNS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
