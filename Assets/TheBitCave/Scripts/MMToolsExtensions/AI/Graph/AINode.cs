using XNode;

namespace TheBitCave.MMToolsExtensions.AI.Graph
{
    /// <summary>
    /// A base node used to extend all AI nodes.
    /// </summary>
    public class AINode : Node
    {
        // We don't care about the return value of the ports.
        // Just return null to stop the console spam.
        public override object GetValue(NodePort port)
        {
            return null;
        }
    }
}
