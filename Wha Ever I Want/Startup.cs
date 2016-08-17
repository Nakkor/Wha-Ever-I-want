using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wha_Ever_I_Want.Startup))]
namespace Wha_Ever_I_Want
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
