using MoreMountains.CorgiEngine;
using MoreMountains.Feedbacks;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionMMFeedbacks"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/MMFeedbacks")]
    public class AIActionMMFeedbacksNode : AIActionNode
    {
        public MMFeedbacks targetFeedbacks;
        public bool onlyPlayWhenEnteringState = true;
        
        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionMMFeedbacks>();
            action.Label = label;
            action.OnlyPlayWhenEnteringState = onlyPlayWhenEnteringState;
            action.TargetFeedbacks = targetFeedbacks;
            return action;
        }
    }
}