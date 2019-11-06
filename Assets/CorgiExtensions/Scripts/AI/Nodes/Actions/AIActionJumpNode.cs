using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionJump"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Jump")]
    public class AIActionJumpNode : AIActionNode
    {
        public int numberOfJumps = 1;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionJump>();
            action.Label = label;
            action.NumberOfJumps = numberOfJumps;
            return action;
        }
    }
}
