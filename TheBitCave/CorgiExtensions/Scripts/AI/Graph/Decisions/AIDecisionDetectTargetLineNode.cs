using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIDecisionDetectTargetLine"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Detect Target Line")]
    public class AIDecisionDetectTargetLineNode : AIDecisionNode
    {
        [NodeEnum] public AIDecisionDetectTargetLine.DetectMethods detectMethod = AIDecisionDetectTargetLine.DetectMethods.Ray;
        [NodeEnum] public AIDecisionDetectTargetLine.DetectionDirections detectionDirection = AIDecisionDetectTargetLine.DetectionDirections.Front;
        public float rayWidth = 1f;
        public float detectionDistance = 10f;
        public Vector3 detectionOriginOffset = new Vector3(0,0,0);
        public LayerMask targetLayer;
        public LayerMask obstaclesLayer;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionDetectTargetLine>();
            decision.Label = label;
            decision.DetectMethod = detectMethod;
            decision.DetectionDirection = detectionDirection;
            decision.RayWidth = rayWidth;
            decision.DetectionDistance = detectionDistance;
            decision.DetectionOriginOffset = detectionOriginOffset;
            decision.TargetLayer = targetLayer;
            decision.ObstaclesLayer = obstaclesLayer;
            return decision;
        }
    }
}