using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionReload"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Reload")]
    public class AIActionReloadNode : AIActionNode
    {
        public bool onlyReloadOnceInThisSate = true;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionReload>();
            action.Label = label;
            action.OnlyReloadOnceInThisSate = onlyReloadOnceInThisSate;
            return action;
        }
    }
}