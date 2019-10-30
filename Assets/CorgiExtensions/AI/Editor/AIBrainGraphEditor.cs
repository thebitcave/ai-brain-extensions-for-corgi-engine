using System;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeGraphEditor(typeof(AIBrainGraph))]
    public class AIBrainGraphEditor : NodeGraphEditor
    {
        public override string GetNodeMenuName(Type type)
        {
            return type.Namespace != "TheBitCave.CorgiExensions.AI" ? null : base.GetNodeMenuName(type);
        }

    }
}