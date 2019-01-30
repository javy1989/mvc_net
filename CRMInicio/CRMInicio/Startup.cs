using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRMInicio.Startup))]
namespace CRMInicio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
