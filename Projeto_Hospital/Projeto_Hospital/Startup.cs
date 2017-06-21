using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projeto_Hospital.Startup))]
namespace Projeto_Hospital
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
