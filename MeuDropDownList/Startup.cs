using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MeuDropDownList.Startup))]
namespace MeuDropDownList
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
