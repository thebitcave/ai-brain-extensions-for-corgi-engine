using System;
using XNodeEditor;
using Object = UnityEngine.Object;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeGraphEditor(typeof(AIBrainGraph))]
    public class AIBrainGraphEditor : NodeGraphEditor
    {
        public override string GetNodeMenuName(Type type)
        {
            return type.Namespace != "TheBitCave.CorgiExensions.AI" ? null : base.GetNodeMenuName(type);
        }

        public override void OnDropObjects(Object[] objects)
        {
            // Does nothing, but suppresses superclass warnings
        }
    }
}