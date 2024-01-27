using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ВиноХармони.Startup))]
namespace ВиноХармони
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
