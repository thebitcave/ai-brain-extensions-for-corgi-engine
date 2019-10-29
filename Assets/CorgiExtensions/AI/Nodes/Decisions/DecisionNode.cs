using MoreMountains.Tools;
using UnityEngine;
using XNode;

namespace TheBitCave.CorgiExensions.AI
{
	[NodeWidth(250)]
	[NodeTint("#aaffaa")]
	[CreateNodeMenu("")]
	public class DecisionNode : Node
	{

		public string label;

		[Input] public string inputState;

		[Output] public string trueState;
		[Output] public string falseState;

		//	[Output] public DecisionNode output;

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
		
		public virtual AIDecision AddDecisionComponent(GameObject go)
		{
			throw new System.NotImplementedException();
		}

	}
}