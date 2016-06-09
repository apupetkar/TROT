using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TROT.Startup))]
namespace TROT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
