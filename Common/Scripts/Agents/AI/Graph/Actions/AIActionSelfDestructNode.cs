using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionSelfDestruct"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Self Destruct")]
    public class AIActionSelfDestructNode : AIActionNode
    {
        public bool onlyRunOnce = true;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionSelfDestruct>();
            action.Label = label;
            action.OnlyRunOnce = onlyRunOnce;
            return action;
        }
    }
}