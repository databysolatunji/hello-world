using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hello_world_local.Startup))]
namespace Hello_world_local
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
