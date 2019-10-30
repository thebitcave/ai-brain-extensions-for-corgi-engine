using UnityEngine;
using XNode;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

namespace TheBitCave.CorgiExensions.AI
{
	/// <summary>
	/// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIDecisionDistanceToTarget"/> decision.
	/// </summary>
	[CreateNodeMenu("AI/Decision/Distance To Target")]
	public class AIDecisionDistanceToTargetNode : AIDecisionNode
	{

		[Header("Settings")]
		
		public float distance;

		[NodeEnum]
		public AIDecisionDistanceToTarget.ComparisonModes comparisonMode =
			AIDecisionDistanceToTarget.ComparisonModes.GreatherThan;
		
		public override AIDecision AddDecisionComponent(GameObject go)
		{
			var decision = go.AddComponent<AIDecisionDistanceToTarget>();
			decision.Label = label;
			decision.Distance = distance;
			decision.ComparisonMode = comparisonMode;
			return decision;
		}

	}
}