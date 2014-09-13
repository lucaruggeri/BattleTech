using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BattleTech.Startup))]
namespace BattleTech
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
