using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TubNet.Startup))]
namespace TubNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
