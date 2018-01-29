using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcDataAssignments.Startup))]
namespace MvcDataAssignments
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
