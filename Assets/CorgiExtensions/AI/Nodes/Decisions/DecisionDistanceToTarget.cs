using UnityEngine;
using XNode;
using MoreMountains.CorgiEngine;

namespace TheBitCave.CorgiExensions.AI
{
	[CreateNodeMenu("AI/Decision/Distance To Target")]
	public class DecisionDistanceToTarget : DecisionNode
	{

		[Header("Settings")] public float distance;

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
	}
}