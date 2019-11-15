using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI;

namespace TheBitCave.CorgiExensions.AI
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIDecisionNextFrame"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Next Frame")]
    public class AIDecisionNextFrameNode : AIDecisionNode
    {
        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionNextFrame>();
            return decision;
        }
    }
}