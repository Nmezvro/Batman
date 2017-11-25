using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Batman.Startup))]
namespace Batman
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
