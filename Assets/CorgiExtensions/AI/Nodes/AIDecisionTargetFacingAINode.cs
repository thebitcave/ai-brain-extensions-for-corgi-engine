using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine;
using XNode;

namespace TheBitCave.CorgiExensions.AI
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