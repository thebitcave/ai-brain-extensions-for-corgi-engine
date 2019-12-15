using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIDecisionGrounded"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Grounded")]
    public class AIDecisionGroundedNode : AIDecisionNode
    {
        public float groundedBufferDelay = 0.2f;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionGrounded>();
            decision.Label = label;
            decision.GroundedBufferDelay = groundedBufferDelay;
            return decision;
        }
    }
}