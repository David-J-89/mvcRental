using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcRental.Startup))]
namespace mvcRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
