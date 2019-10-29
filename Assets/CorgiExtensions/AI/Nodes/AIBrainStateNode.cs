using System;
using UnityEngine;
using XNode;

namespace TheBitCave.CorgiExensions.AI
{
	[CreateNodeMenu("AI/Brain State")]
	public class AIBrainStateNode : Node
	{

		public bool defaultState;

		[Input] public TransitionConnection transitionsIn;

		[Input] public ActionConnection actions;

		[Output] public DecisionConnection decisions;

		
		// Use this for initialization
		protected override void Init()
		{
			base.Init();
		}

		// Return the correct value of an output port when requested
		public override object GetValue(NodePort port)
		{
			return null;
		}
	}
}