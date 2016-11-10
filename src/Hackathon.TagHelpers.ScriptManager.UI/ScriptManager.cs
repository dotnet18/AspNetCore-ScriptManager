using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hackathon.TagHelpers.ScriptManager.Core;

namespace Hackathon.TagHelpers.ScriptManager.UI
{
    public class ScriptManager : IScriptManager
    {
        public IList<ScriptReference> Scripts { get; }

        public ScriptManager()
        {
            Scripts = new List<ScriptReference>();
        }

        public void AddScript(string scriptPath)
        {
            if (Scripts.All(x => x.ScriptPath != scriptPath))
            {
                Scripts.Add(new ScriptReference(scriptPath));
            }
        }
    }
}
