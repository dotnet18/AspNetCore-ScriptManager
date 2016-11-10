using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Hackathon.Amazing.TagHelpers
{
    public class BodyTagHelper : TagHelper
    {
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

        
			var sb = new StringBuilder();

            sb.AppendFormat("<script>$(function() {{ $('." + DatePickerDefaults.UniquePageClassName + "').datepicker(); }} ); </script>");

            output.PostContent.AppendHtml(sb.ToString());
        }
    }
}
