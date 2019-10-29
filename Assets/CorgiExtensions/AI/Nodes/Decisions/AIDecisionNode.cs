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

		[Input(connectionType = ConnectionType.Override, typeConstraint = TypeConstraint.Strict)] public DecisionConnection inputState;

		[Output(connectionType = ConnectionType.Override)] public TransitionConnection trueState;
		[Output(connectionType = ConnectionType.Override)] public TransitionConnection falseState;

		// Use this for initialization
		protected override void Init()
		{
			base.Init();

		}

		public string GetTrueStateLabel()
		{
			if (GetOutputPort(C.PORT_TRUE_STATE).Connection == null) return "";
			return GetOutputPort(C.PORT_TRUE_STATE).Connection.node.name;
		}

		public string GetFalseStateLabel()
		{
			if (GetOutputPort(C.PORT_FALSE_STATE).Connection == null) return "";
			return GetOutputPort(C.PORT_FALSE_STATE).Connection.node.name;
		}

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