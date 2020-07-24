using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VShop.Startup))]
namespace VShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
