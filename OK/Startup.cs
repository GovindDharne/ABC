using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OK.Startup))]
namespace OK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
