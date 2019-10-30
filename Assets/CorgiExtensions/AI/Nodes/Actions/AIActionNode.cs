using MoreMountains.Tools;
using UnityEngine;
using XNode;
using System;

namespace TheBitCave.CorgiExensions.AI
{
	[NodeTint("#ffaaaa")]
	[NodeWidth(250)]
	[CreateNodeMenu("")]
	public class AIActionNode : AINode
	{

		public string label;

		[Output(connectionType = ConnectionType.Multiple)] public ActionConnection output;
		
		public virtual AIAction AddActionComponent(GameObject go)
		{
			throw new System.NotImplementedException();
		}
	}
}

