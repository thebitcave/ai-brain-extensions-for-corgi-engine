using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

namespace TheBitCave.CorgiExensions.AI
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIDecisionHealth"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Health")]
    public class AIDecisionHealthNode : AIDecisionNode
    {
        public AIDecisionHealth.ComparisonModes trueIfHealthIs;
        public int healthValue;
        public bool onlyOnce = true;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionHealth>();
            decision.Label = label;
            decision.TrueIfHealthIs = trueIfHealthIs;
            decision.HealthValue = healthValue;
            decision.OnlyOnce = onlyOnce;
            return decision;
        }
    }
}
