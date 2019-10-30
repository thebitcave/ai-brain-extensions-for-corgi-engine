using MoreMountains.Tools;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI
{
	[NodeWidth(250)]
	[NodeTint("#aaffaa")]
	[CreateNodeMenu("")]
	public class AIDecisionNode : AINode
	{
		public string label;

		[Output(connectionType = ConnectionType.Multiple)] public DecisionConnection output;
		
		public virtual AIDecision AddDecisionComponent(GameObject go)
		{
			throw new System.NotImplementedException();
		}
	}
}