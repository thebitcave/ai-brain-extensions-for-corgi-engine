using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using UnityEngine;
using XNode;

namespace TheBitCave.CorgiExensions.AI
{
    [NodeWidth(150)]
    [CreateNodeMenu("AI/Transition")]
    [NodeTint("#aaffff")]
    public class AITransitionNode : AINode
    {
        [Input(connectionType = ConnectionType.Override, typeConstraint = TypeConstraint.Strict)] public DecisionConnection decision;
        [Input(connectionType = ConnectionType.Override, typeConstraint = TypeConstraint.Strict)] public TransitionConnection input;

        [Output(connectionType = ConnectionType.Override)] public StateConnection trueState;
        [Output(connectionType = ConnectionType.Override)] public StateConnection falseState;

        public string GetTrueStateLabel()
        {
            if (GetOutputPort(C.PORT_TRUE_STATE).Connection == null) return "";
            return GetOutputPort(C.PORT_TRUE_STATE).Connection.node.name;
        }

        public string GetFalseStateLabel()
        {
            if (GetOutputPort(C.PORT_FALSE_STATE).Connection == null) return "";
            return GetOutputPort(C.PORT_FALSE_STATE).Connection.node.name;
        }

        public AIDecisionNode GetDecision()
        {
            if (GetInputPort(C.PORT_DECISION).Connection == null) return null;
            return GetInputPort(C.PORT_DECISION).Connection.node as AIDecisionNode;
        }
    }
}