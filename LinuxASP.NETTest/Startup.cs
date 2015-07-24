using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LinuxASP.NETTest.Startup))]
namespace LinuxASP.NETTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
