using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BiniTutor.Startup))]
namespace BiniTutor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
