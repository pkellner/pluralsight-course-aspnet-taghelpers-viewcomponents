namespace WebAppTagHelper
{
    /// <summary>
    /// Refers to an included script using the script tag src attribute.
    /// IncludeOrderPriority is so that higher order scripts are included later.
    /// That is, if you want jQueryUI to be always after jQuery, you need to make
    /// sure that the includeOrderPriority of jQueryUI is higher than jQuery.
    /// The sort is low to high and files are rendered in that order.
    /// </summary>
    public class ScriptReference
    {
        public string ScriptPath { get; private set; }
        public int IncludeOrderPriorty { get; private set; }

        public ScriptReference(string scriptPath, int includeOrderPriorty = 0)
        {
            ScriptPath = scriptPath;
            IncludeOrderPriorty = includeOrderPriorty;
        }
    }
}
