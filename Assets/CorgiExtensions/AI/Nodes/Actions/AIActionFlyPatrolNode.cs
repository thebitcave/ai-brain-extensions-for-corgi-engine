using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using UnityEngine;
using XNode;

namespace TheBitCave.CorgiExensions.AI
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionFlyPatrol"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Fly Patrol")]
    public class AIActionFlyPatrolNode : AIActionNode
    {

        [Header("Obstacle Detection")] public bool changeDirectionOnObstacle = true;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionFlyPatrol>();
            action.ChangeDirectionOnObstacle = changeDirectionOnObstacle;
            action.Label = label;
            return action;
        }
    }
}