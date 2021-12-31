using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionResetTarget"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Reset Target Node")]
    public class AIActionResetTargetNode : AIActionNode
    {
        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionResetTarget>();
            action.Label = label;
            return action;
        }
    }
}