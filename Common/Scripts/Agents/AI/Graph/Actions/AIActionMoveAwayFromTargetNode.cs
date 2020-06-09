using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionMoveAwayFromTarget"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Move Away From Target")]
    public class AIActionMoveAwayFromTargetNode : AIActionNode
    {
        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionMoveAwayFromTarget>();
            action.Label = label;
            return action;
        }
    }
}