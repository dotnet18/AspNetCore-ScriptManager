using System;
using System.Collections.Generic;
using System.Text;
using Hackathon.TagHelpers.ScriptManager.Core;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Hackathon.Amazing.TagHelpers
{
    public class DatePickerTagHelper : TagHelper
    {
        private IScriptManager _scriptManager;

        private const string JQueryPath = "https://code.jquery.com/jquery-1.12.4.js";
        private const string JQueryUiPath = "https://code.jquery.com/ui/1.12.1/jquery-ui.js";

        public DatePickerTagHelper(IScriptManager scriptManager)
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

            // add scripts
            _scriptManager.AddScript(JQueryPath);
            _scriptManager.AddScript(JQueryUiPath);

            // generate html code
            var sb = new StringBuilder();

            sb.Append($"<input type='text' class='{ DatePickerDefaults.UniquePageClassName }' />");

            output.Content.SetHtmlContent(sb.ToString());
        }
    }
}
