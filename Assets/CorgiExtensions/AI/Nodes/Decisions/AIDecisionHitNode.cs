using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

namespace TheBitCave.CorgiExensions.AI
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIDecisionHit"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Hit")]
    public class AIDecisionHitNode : AIDecisionNode
    {
        public int numberOfHits = 1;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionHit>();
            decision.Label = label;
            decision.NumberOfHits = numberOfHits;
            return decision;
        }
    }
}