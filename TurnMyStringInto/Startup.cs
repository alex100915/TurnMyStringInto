using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TurnMyStringInto.Startup))]
namespace TurnMyStringInto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
