using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIDecisionTimeInState"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Time In State")]
    public class AIDecisionTimeInStateNode : AIDecisionNode
    {
        public float afterTimeMin = 2f;
        public float afterTimeMax = 2f;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionTimeInState>();
            decision.Label = label;
            decision.AfterTimeMin = afterTimeMin;
            decision.AfterTimeMax = afterTimeMax;
            return decision;
        }
    }
}