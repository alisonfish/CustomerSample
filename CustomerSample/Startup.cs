using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerSample.Startup))]
namespace CustomerSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
