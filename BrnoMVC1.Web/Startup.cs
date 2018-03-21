using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrnoMVC1.Web.Startup))]
namespace BrnoMVC1.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
