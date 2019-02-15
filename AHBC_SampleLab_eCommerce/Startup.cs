using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AHBC_SampleLab_eCommerce.Startup))]
namespace AHBC_SampleLab_eCommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
