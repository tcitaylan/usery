using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngEx.Startup))]
namespace AngEx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
