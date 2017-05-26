using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Administracion_Cliente_PEV.Startup))]
namespace Administracion_Cliente_PEV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
