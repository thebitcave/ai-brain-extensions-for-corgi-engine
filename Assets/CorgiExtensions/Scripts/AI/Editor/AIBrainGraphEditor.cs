using System;
using UnityEngine;
using XNodeEditor;
using Object = UnityEngine.Object;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeGraphEditor(typeof(AIBrainGraph))]
    public class AIBrainGraphEditor : NodeGraphEditor
    {
        public override string GetNodeMenuName(Type type)
        {
            return type.IsSubclassOf(typeof(AINode)) ? base.GetNodeMenuName(type) : null;
        }

        public override void OnDropObjects(Object[] objects)
        {
            // Does nothing, but suppresses superclass warnings
        }
    }
}