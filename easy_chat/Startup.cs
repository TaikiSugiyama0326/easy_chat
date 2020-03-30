using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(easy_chat.Startup))]
namespace easy_chat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
