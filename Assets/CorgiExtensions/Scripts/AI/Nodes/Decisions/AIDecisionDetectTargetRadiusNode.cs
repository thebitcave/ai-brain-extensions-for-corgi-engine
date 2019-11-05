using UnityEngine;
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
        
        public float radius = 3f;
        public Vector3 detectionOriginOffset = new Vector3(0, 0, 0);
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