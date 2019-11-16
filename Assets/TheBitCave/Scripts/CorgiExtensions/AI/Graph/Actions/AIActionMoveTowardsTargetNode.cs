using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionMoveTowardsTarget"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Move Towards Target")]
    public class AIActionMoveTowardsTargetNode : AIActionNode
    {
        public float minimumDistance = 1f;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionMoveTowardsTarget>();
            action.Label = label;
            action.MinimumDistance = minimumDistance;
            return action;
        }

    }
}
