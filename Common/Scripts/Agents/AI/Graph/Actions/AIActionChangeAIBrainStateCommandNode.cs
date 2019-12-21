using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="TheBitCave.MMToolsExtensions.AI.AIActionChangeAIBrainStateCommand"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Extensions/Change AIBrain State Command")]
    public class AIActionChangeAIBrainStateCommandNode : AIActionNode
    {
        public string channelName;
        public string stateName;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionChangeAIBrainStateCommand>();
            action.Label = label;
            action.ChannelName = channelName;
            action.StateName = stateName;
            return action;
        }
    }
}