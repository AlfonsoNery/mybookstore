using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mybookstore.Startup))]
namespace mybookstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
