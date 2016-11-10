using Hackathon.TagHelpers.ScriptManager.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Hackathon.TagHelpers.ScriptManager.UI
{
    public static class ScriptManagerExtensions
    {
        public static void AddScriptManager(this IServiceCollection services)
        {
            services.AddScoped<IScriptManager, ScriptManager>();
        }
    }
}
