using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace WebAppTagHelper
{
    public interface IScriptManager
    {
        void AddScript(ScriptReference script);

        List<ScriptReference> Scripts { get; }
        List<string> ScriptTexts { get; }
        void AddScriptText(string scriptTextExecute);
    }
}
