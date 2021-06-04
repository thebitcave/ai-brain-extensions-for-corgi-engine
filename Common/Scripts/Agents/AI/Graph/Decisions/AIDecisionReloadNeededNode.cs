using UnityEngine;
using XNode;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIDecisionReloadNeeded"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Reload Needed")]
    public class AIDecisionReloadNeededNode : AIDecisionNode
    {
        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionDistanceToTarget>();
            decision.Label = label;
            return decision;
        }
    }
}