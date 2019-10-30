using UnityEngine;
using XNode;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

namespace TheBitCave.CorgiExensions.AI
{
	[CreateNodeMenu("AI/Decision/Distance To Target")]
	public class AIDecisionDistanceToTargetNode : AIDecisionNode
	{

		[Header("Settings")]
		
		public float distance;

		[NodeEnum]
		public AIDecisionDistanceToTarget.ComparisonModes comparisonMode =
			AIDecisionDistanceToTarget.ComparisonModes.GreatherThan;

		// Use this for initialization
		protected override void Init()
		{
			base.Init();

		}

		// Return the correct value of an output port when requested
		public override object GetValue(NodePort port)
		{
			return null; // Replace this
		}
		
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