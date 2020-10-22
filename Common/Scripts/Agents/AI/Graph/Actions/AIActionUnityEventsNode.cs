using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;
using UnityEngine.Events;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionUnityEvents"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Unity Events")]
    public class AIActionUnityEventsNode : AIActionNode
    {
        public UnityEvent targetEvent;
        public bool onlyPlayWhenEnteringState = true;
        
        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionUnityEvents>();
            action.Label = label;
            action.OnlyPlayWhenEnteringState = onlyPlayWhenEnteringState;
            action.TargetEvent = targetEvent;
            return action;
        }
    }
}