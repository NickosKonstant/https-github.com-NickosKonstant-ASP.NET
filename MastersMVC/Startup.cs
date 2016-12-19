using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MastersMVC.Startup))]
namespace MastersMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
