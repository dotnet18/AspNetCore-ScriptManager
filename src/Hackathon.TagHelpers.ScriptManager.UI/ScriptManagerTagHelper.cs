using System;
using System.Text;
using Hackathon.TagHelpers.ScriptManager.Core;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Hackathon.TagHelpers.ScriptManager.UI
{
    public class ScriptManagerTagHelper : TagHelper
    {
        private readonly IScriptManager _scriptManager;

        public ScriptManagerTagHelper(IScriptManager scriptManager)
        {
            _scriptManager = scriptManager;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (output == null)
            {
                throw new ArgumentNullException(nameof(output));
            }

            output.TagName = string.Empty;

            var sb = new StringBuilder();

            foreach (var scriptReference in _scriptManager.Scripts)
            {
                // add script
                sb.AppendLine($"<script type='text/javascript' src='{scriptReference.ScriptPath}'></script>");
            }

            output.Content.SetHtmlContent(sb.ToString());            
        }
    }
}
