using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionPatrolWithinBounds"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Patrol Within Bounds")]
    public class AIActionPatrolWithinBoundsNode : AIActionPatrolNode
    {
        [Header("Bounds")]

        [NodeEnum] public AIActionPatrolWithinBounds.BoundsMethods boundsMethod = AIActionPatrolWithinBounds.BoundsMethods.BasedOnOriginPosition;
        public float boundsExtentsLeft;
        public float boundsExtentsRight;


        public override AIAction AddActionComponent(GameObject go)
        {
            base.AddActionComponent(go);
            var action = go.AddComponent<AIActionPatrolWithinBounds>();
            action.Label = label;

            action.BoundsMethod = boundsMethod;
            action.BoundsExtentsLeft = boundsExtentsLeft;
            action.BoundsExtentsRight = boundsExtentsRight;
            
            action.ChangeDirectionOnWall = changeDirectionOnWall;
            action.AvoidFalling = avoidFalling;
            action.HoleDetectionOffset = holeDetectionOffset;
            action.HoleDetectionRaycastLength = holeDetectionRaycastLength;
            return action;
        }
    }
}
