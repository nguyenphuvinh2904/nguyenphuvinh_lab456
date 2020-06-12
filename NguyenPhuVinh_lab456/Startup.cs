using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenPhuVinh_lab456.Startup))]
namespace NguyenPhuVinh_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
