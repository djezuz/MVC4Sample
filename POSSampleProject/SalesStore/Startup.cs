using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesStore.Startup))]
namespace SalesStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
