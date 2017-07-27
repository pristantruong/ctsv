using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPCTSV.Startup))]
namespace WebPCTSV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
