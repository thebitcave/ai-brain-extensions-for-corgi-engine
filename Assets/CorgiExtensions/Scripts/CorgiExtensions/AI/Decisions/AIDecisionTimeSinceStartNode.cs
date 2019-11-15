using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI;

namespace TheBitCave.CorgiExensions.AI
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIDecisionTimeSinceStart"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Time Since Start")]
    public class AIDecisionTimeSinceStartNode : AIDecisionNode
    {
        public float afterTime;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionTimeSinceStart>();
            decision.Label = label;
            decision.AfterTime = afterTime;
            return decision;
        }
    }
}