using MoreMountains.Tools;
using UnityEngine;
using XNode;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TheBitCave.CorgiExensions.AI
{
	[NodeWidth(250)]
	[NodeTint("#aaffaa")]
	[CreateNodeMenu("")]
	public class AIDecisionNode : Node
	{

		public string label;

		[Output(connectionType = ConnectionType.Multiple)] public DecisionConnection output;
		
		// Return the correct value of an output port when requested
		public override object GetValue(NodePort port)
		{
			return null;
		}
		
		public virtual AIDecision AddDecisionComponent(GameObject go)
		{
			throw new System.NotImplementedException();
		}
	}
}