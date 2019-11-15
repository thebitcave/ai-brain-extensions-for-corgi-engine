using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI;

namespace TheBitCave.CorgiExensions.AI
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIDecisionRandom"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Random")]
    public class AIDecisionRandomNode : AIDecisionNode
    {
        public int totalChance = 10;
        public int odds = 4;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionRandom>();
            decision.TotalChance = totalChance;
            decision.Odds = odds;
            return decision;
        }
    }
}
