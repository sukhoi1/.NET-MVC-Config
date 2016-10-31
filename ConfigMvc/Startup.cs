using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConfigMvc.Startup))]
namespace ConfigMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
