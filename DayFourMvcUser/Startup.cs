using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DayFourMvcUser.Startup))]
namespace DayFourMvcUser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
