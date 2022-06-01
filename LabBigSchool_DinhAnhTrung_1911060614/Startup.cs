using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabBigSchool_DinhAnhTrung_1911060614.Startup))]
namespace LabBigSchool_DinhAnhTrung_1911060614
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
