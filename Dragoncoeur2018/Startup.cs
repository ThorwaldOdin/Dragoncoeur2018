using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dragoncoeur2018.Startup))]
namespace Dragoncoeur2018
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
