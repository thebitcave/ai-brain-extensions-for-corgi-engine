namespace TheBitCave.CorgiExensions.AI
{
    /// <summary>
    /// A node representing a single Corgi <see cref="MoreMountains.Tools.AITransition"/>.
    /// </summary>
    [NodeWidth(150)]
    [CreateNodeMenu("AI/Transition")]
    [NodeTint("#457B9D")]
    public class AITransitionNode : AINode
    {
        [Input(connectionType = ConnectionType.Override, typeConstraint = TypeConstraint.Strict)] public DecisionConnection decision;
        [Input(connectionType = ConnectionType.Override, typeConstraint = TypeConstraint.Strict)] public TransitionConnection input;

        [Output(connectionType = ConnectionType.Override)] public StateConnection trueState;
        [Output(connectionType = ConnectionType.Override)] public StateConnection falseState;

        /// <summary>
        /// Returns the label for the transition True state.
        /// </summary>
        /// <returns>The transition True state label</returns>
        public string GetTrueStateLabel()
        {
            return GetOutputPort(C.PORT_TRUE_STATE).Connection == null ? "" : GetOutputPort(C.PORT_TRUE_STATE).Connection.node.name;
        }

        /// <summary>
        /// Returns the label for the transition False state.
        /// </summary>
        /// <returns>The transition False state label</returns>
        public string GetFalseStateLabel()
        {
            return GetOutputPort(C.PORT_FALSE_STATE).Connection == null ? "" : GetOutputPort(C.PORT_FALSE_STATE).Connection.node.name;
        }

        /// <summary>
        /// Gets the decision for this transition.
        /// </summary>
        /// <returns>The decision node for this transition</returns>
        public AIDecisionNode GetDecision()
        {
            if (GetInputPort(C.PORT_DECISION).Connection == null) return null;
            return GetInputPort(C.PORT_DECISION).Connection.node as AIDecisionNode;
        }
    }
}