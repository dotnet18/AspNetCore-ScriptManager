using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Hackathon.Amazing.TagHelpers.DatePicker
{
    public class BodyTagHelper : TagHelper
    {
        public override int Order => -1001;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            throw new NotImplementedException();
        }

        public async override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
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
            sb.AppendFormat("<script>$(function() {{ $('." + DatePickerDefaults.UniquePageClassName + "').datepicker(); }} ); </script>");
            
            output.PostContent.AppendHtml(sb.ToString());

            await Task.CompletedTask;
        }
    }
}
