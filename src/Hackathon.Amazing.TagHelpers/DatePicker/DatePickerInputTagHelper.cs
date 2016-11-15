using System;
using System.Collections.Generic;
using System.Text;
using Hackathon.TagHelpers.ScriptManager.Core;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Hackathon.Amazing.TagHelpers.DatePicker
{
    [HtmlTargetElement("input", Attributes = ForAttributeName, TagStructure = TagStructure.WithoutEndTag)]

    public class DatePickerInputTagHelper : TagHelper
    {
        private const string ForAttributeName = "date-picker";
      
        public override int Order => -1001;

        private readonly IScriptManager _scriptManager;

        private const string JQueryPath = "https://code.jquery.com/jquery-1.12.4.js";
        private const string JQueryUiPath = "https://code.jquery.com/ui/1.12.1/jquery-ui.js";

        public DatePickerInputTagHelper(IScriptManager scriptManager)
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
           
            // add scripts
            _scriptManager.AddScript(JQueryPath);
            _scriptManager.AddScript(JQueryUiPath);

            // add date-picker unique class name
            output.Attributes.RemoveAll(ForAttributeName);
            var existingClass = output.Attributes["class"];

            output.Attributes.SetAttribute("class", 
                DatePickerDefaults.UniquePageClassName + " " + existingClass?.Value);
        }
    }
}
