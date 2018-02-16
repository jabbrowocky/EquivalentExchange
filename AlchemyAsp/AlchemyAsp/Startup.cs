using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlchemyAsp.Startup))]
namespace AlchemyAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
