using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PayrollManagement.Startup))]
namespace PayrollManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
