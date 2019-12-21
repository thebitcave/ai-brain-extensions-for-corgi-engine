using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI.Graph
{
	/// <summary>
	/// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIDecisionTargetFacingAI"/> decision.
	/// </summary>
	[CreateNodeMenu("AI/Decision/Target Facing AI")]
	public class AIDecisionTargetFacingAINode : AIDecisionNode
	{
		public override AIDecision AddDecisionComponent(GameObject go)
		{
			var decision = go.AddComponent<AIDecisionTargetFacingAI>();
			decision.Label = label;
			return decision;
		}
	}
}