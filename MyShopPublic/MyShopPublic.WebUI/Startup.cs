using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShopPublic.WebUI.Startup))]
namespace MyShopPublic.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
