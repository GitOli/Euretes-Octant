using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Euretes_Octant.Startup))]
namespace Euretes_Octant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
