using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webDayCareCenter.Startup))]
namespace webDayCareCenter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
