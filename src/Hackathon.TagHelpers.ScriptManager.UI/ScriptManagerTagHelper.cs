//using System;
//using System.Text;
//using Hackathon.TagHelpers.ScriptManager.Core;
//using Microsoft.AspNetCore.Razor.TagHelpers;

//namespace Hackathon.TagHelpers.ScriptManager.UI
//{
//    [HtmlTargetElement("script", Attributes = ForAttributeName)]

//    public class ScriptManagerScriptTagHelper : TagHelper
//    {
//        private const string ForAttributeName = "src";


//        private readonly IScriptManager _scriptManager;

//        public ScriptManagerScriptTagHelper(IScriptManager scriptManager)
//        {
//            _scriptManager = scriptManager;
//        }

//        public override void Process(TagHelperContext context, TagHelperOutput output)
//        {
//            if (context == null)
//            {
//                throw new ArgumentNullException(nameof(context));
//            }

//            if (output == null)
//            {
//                throw new ArgumentNullException(nameof(output));
//            }

//            //output.TagName = string.Empty;

//            //var sb = new StringBuilder();

//            //foreach (var scriptReference in _scriptManager.Scripts)
//            //{
//            //    // add script
//            //    sb.AppendLine($"<script type='text/javascript' src='{scriptReference.ScriptPath}'></script>");
//            //}

//            //output.Content.SetHtmlContent(sb.ToString());
//        }
//    }
//}
