using MoreMountains.Tools;
using UnityEngine;
using XNode;
using System;

namespace TheBitCave.CorgiExensions.AI
{
	[NodeTint("#ffaaaa")]
	[NodeWidth(250)]
	[CreateNodeMenu("")]
	public class AIActionNode : Node
	{

		public string label;

		[Output(connectionType = ConnectionType.Multiple)] public ActionConnection output;

		// Return the correct value of an output port when requested
		public override object GetValue(NodePort port)
		{
			return null;
		}

		public virtual AIAction AddActionComponent(GameObject go)
		{
			throw new System.NotImplementedException();
		}
	}
}

