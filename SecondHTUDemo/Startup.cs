using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecondHTUDemo.Startup))]
namespace SecondHTUDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
