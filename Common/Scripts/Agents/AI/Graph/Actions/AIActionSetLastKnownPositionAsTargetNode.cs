using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;
using XNode;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionSetLastKnownPositionAsTarget"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Set Last Known Position As Target")]
    public class AIActionSetLastKnownPositionAsTargetNode : AIActionNode
    {

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionSetLastKnownPositionAsTarget>();
            action.Label = label;
            return action;
        }
    }
}