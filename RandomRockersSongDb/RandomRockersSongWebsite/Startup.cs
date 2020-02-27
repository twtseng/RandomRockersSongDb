using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RandomRockersSongWebsite.Startup))]
namespace RandomRockersSongWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
