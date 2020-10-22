using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionSwapBrain"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Swap Brain")]
    public class AIActionSwapBrainNode : AIActionNode
    {
        public AIBrain newAIBrain;
        
        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionSwapBrain>();
            action.Label = label;
            action.NewAIBrain = newAIBrain;
            return action;
        }

    }
}