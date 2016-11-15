using System;
using System.Text;
using System.Threading.Tasks;
using Hackathon.TagHelpers.ScriptManager.Core;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Hackathon.TagHelpers.ScriptManager.UI
{
    [HtmlTargetElement("body", Attributes = ForAttributeName)]    

    public class BodyTagHelper : TagHelper
    {
        private const string ForAttributeName = "script-manager";

        private readonly IScriptManager _scriptManager;

        public override int Order => -1005;

        public BodyTagHelper(IScriptManager scriptManager)
        {
            _scriptManager = scriptManager;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            throw new NotImplementedException();
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (output == null)
            {
                throw new ArgumentNullException(nameof(output));
            }

            await output.GetChildContentAsync();

            var sb = new StringBuilder();
            foreach (var scriptReference in _scriptManager.Scripts)
            {
                // add script
                sb.AppendLine($"<script type='text/javascript' src='{scriptReference.ScriptPath}'></script>");
            }
            
            output.PostContent.AppendHtml(sb.ToString());

            await Task.CompletedTask;
        }
    }
}
