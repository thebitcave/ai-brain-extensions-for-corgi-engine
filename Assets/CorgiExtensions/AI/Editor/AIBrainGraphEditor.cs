using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeGraphEditor(typeof(AIBrainGraph))]
    public class AIBrainGraphEditor : NodeGraphEditor
    {
        public override string GetNodeMenuName(Type type)
        {
            if (type.Namespace != "TheBitCave.CorgiExensions.AI") return null;

            return base.GetNodeMenuName(type);
        }

    }
}