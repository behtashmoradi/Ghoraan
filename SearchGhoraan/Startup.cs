using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SearchGhoraan.Startup))]
namespace SearchGhoraan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
