using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AW_Demo01.Startup))]
namespace AW_Demo01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
