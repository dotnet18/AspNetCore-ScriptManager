using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon.TagHelpers.ScriptManager.Core
{
    public class ScriptReference
    {
        public string ScriptPath { get; private set; }

        public ScriptReference(string scriptPath)
        {
            ScriptPath = scriptPath;
        }
    }
}
