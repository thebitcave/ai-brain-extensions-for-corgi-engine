using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

namespace TheBitCave.CorgiExensions.AI
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIDecisionLineOfSightToTarget"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Line Of Sight To Target")]
    public class AIDecisionLineOfSightToTargetNode : AIDecisionNode
    {
        public LayerMask obstacleLayerMask;
        public Vector3 lineOfSightOffset = new Vector3(0, 0, 0);

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionLineOfSightToTarget>();
            decision.Label = label;
            decision.ObstacleLayerMask = obstacleLayerMask;
            decision.LineOfSightOffset = lineOfSightOffset;
            return decision;
        }
    }
}