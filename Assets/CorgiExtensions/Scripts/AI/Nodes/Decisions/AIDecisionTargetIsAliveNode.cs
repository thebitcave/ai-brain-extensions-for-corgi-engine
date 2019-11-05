using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

namespace TheBitCave.CorgiExensions.AI
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIDecisionTargetIsAlive"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Target Is Alive")]
    public class AIDecisionTargetIsAliveNode : AIDecisionNode
    {
        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionTargetIsAlive>();
            return decision;
        }
    }
}