using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AtividadePiso.Web.Startup))]
namespace AtividadePiso.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
