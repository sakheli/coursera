using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coursera.Startup))]
namespace Coursera
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
