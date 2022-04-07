using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace MVCApp.Services
{
    public static class Testers
    {
        public static void AddTesterService(this IServiceCollection service)
        {
            service.AddSingleton<ITesting, Testing>();
        }
    }
}
