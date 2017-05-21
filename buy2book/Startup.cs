using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(buy2book.Startup))]
namespace buy2book
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
