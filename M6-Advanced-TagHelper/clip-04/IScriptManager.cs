using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace WebAppTagHelper
{
    public interface IScriptManager
    {
        List<ScriptReference> Scripts { get; }
        List<string> ScriptTexts { get; }
        void AddScriptText(string scriptTextExecute);
        void AddScript(ScriptReference script);
    }
}
