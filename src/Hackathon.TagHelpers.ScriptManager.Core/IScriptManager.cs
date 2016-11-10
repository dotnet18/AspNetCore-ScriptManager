using System;
using System.Collections.Generic;

namespace Hackathon.TagHelpers.ScriptManager.Core
{
    public interface IScriptManager
    {
        IList<ScriptReference> Scripts { get; }

        void AddScript(string scriptPath);        
    }
}
