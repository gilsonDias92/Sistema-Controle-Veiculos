using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControleVeiculos2019.Startup))]
namespace ControleVeiculos2019
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
