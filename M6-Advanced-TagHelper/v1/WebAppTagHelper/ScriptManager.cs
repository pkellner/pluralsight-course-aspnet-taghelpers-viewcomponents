using System.Collections.Generic;
using System.Linq;

namespace WebAppTagHelper
{
    /// <summary>
    ///     ScriptManager keeps track of all the scripts (referenced javascript files) and scriptTexts (blocks of actual
    ///     javascript)
    ///     that have been added to the project.  ScriptManager makes sure there are no duplicates add so when it is time to
    ///     output the
    ///     javascript files, they are already deduped.
    /// </summary>
    public class ScriptManager : IScriptManager
    {
        // getter only prop retrieves scripts
        // this is the filenames (or URL's) of the script tags
        private readonly List<ScriptReference> _scripts = new List<ScriptReference>();

        public List<ScriptReference> Scripts => _scripts;
        public List<string> ScriptTexts { get; } = new List<string>();

        public void AddScript(ScriptReference scriptReference)
        {
            if (Scripts.All(x => x.ScriptPath != scriptReference.ScriptPath))
                _scripts.Add(scriptReference);
        }

        public void AddScriptText(string scriptTextExecute)
        {
            if (!ScriptTexts.Contains(scriptTextExecute))
                ScriptTexts.Add(scriptTextExecute);
        }
    }
}