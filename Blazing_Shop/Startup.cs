using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAppBlazingShop.Startup))]
namespace MVCAppBlazingShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
