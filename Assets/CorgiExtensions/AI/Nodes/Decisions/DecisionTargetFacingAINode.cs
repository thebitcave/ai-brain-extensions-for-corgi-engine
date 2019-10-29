using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine;
using XNode;

namespace TheBitCave.CorgiExensions.AI
{
	[CreateNodeMenu("AI/Decision/Target Facing AI")]
	public class DecisionTargetFacingAINode : DecisionNode
	{

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
			var decision = go.AddComponent<AIDecisionTargetFacingAI>();
			decision.Label = label;
			return decision;
		}

	}
}