using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using UnityEngine;
using XNode;

namespace TheBitCave.CorgiExensions.AI
{
	[CreateNodeMenu("AI/Action/Do Nothing")]
	public class ActionDoNothingNode : ActionNode
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

		public override AIAction AddActionComponent(GameObject go)
		{
			var action = go.AddComponent<AIActionDoNothing>();
			action.Label = label;
			return action;
		}

	}
	
}
