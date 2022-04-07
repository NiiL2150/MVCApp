using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace MVCApp.Services
{
    public static class Visitors
    {
        public static void AddVisitorService(this IServiceCollection service)
        {
            service.AddSingleton<IVisit, Visit>();
        }

        public static void UseVisitors(this IApplicationBuilder app)
        {
            app.UseMiddleware<VisitMiddleware>();
        }
    }
}
