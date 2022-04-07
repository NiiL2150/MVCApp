using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MVCApp.Services
{
    public class VisitMiddleware
    {
        private readonly RequestDelegate _next;

        public VisitMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IVisit visit)
        {
            if(context.Request.Path.Value != null && !context.Request.Path.Value.StartsWith("/favicon.ico"))
            {
                visit.Visits++;
            }
            await _next.Invoke(context);
        }
    }
}
