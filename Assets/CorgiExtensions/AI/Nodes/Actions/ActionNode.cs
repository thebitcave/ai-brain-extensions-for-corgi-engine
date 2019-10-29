using UnityEngine;
using XNode;

namespace TheBitCave.CorgiExensions.AI
{
	[NodeTint("#ffaaaa")]
	[NodeWidth(250)]
	[CreateNodeMenu("")]
	public class ActionNode : Node
	{

		public string label;

		[Output] public Node output;

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