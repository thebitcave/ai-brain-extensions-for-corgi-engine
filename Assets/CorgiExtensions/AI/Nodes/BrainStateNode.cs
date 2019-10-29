using UnityEngine;
using XNode;

namespace TheBitCave.CorgiExensions.AI
{
	public class BrainStateNode : Node
	{

		[Input] public string transitionIn;

		//public string stateName;
		[Input] public ActionNode[] actions;
		//[Input] public DecisionNode[] transitions;

		[Output] public string transitions;

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

		[ContextMenu("Log Name")]
		public void Execute()
		{
			Debug.Log(name);
		}

	}
}