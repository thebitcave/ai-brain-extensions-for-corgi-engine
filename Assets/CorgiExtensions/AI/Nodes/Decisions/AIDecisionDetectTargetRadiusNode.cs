using UnityEngine;
using XNode;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

namespace TheBitCave.CorgiExensions.AI
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIDecisionDetectTargetRadius"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Detect Target Radius")]
    public class AIDecisionDetectTargetRadiusNode : AIDecisionNode
    {
        [Header("Settings")]
        
        /// The radius to search our target in
        public float radius = 3f;
        /// The center of the search circle
        public Vector3 detectionOriginOffset = new Vector3(0, 0, 0);
        /// The layer(s) to search our target on
        public LayerMask targetLayer;
        
        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionDetectTargetRadius>();
            decision.Label = label;
            decision.Radius = radius;
            decision.DetectionOriginOffset = detectionOriginOffset;
            decision.TargetLayer = targetLayer;
            return decision;
        }
    }
}