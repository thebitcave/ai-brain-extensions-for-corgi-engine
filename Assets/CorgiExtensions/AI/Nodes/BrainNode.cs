using UnityEngine;
using XNode;

namespace TheBitCave.CorgiExensions.AI
{
	[CreateNodeMenu("AI/Brain")]
	[NodeTint("#aaaaff")]
	public class BrainNode : Node
	{

		[Input] public BrainStateNode[] states;
		[Input] public float actionsFrequency;
		[Input] public float decisionFrequency;

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