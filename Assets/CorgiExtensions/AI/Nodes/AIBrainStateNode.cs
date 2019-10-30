using System;
using UnityEditor;
using UnityEngine;
using XNode;

namespace TheBitCave.CorgiExensions.AI
{
	/// <summary>
	/// A node representing a single state in the Corgi <see cref="MoreMountains.Tools.AIBrain"/>.
	/// </summary>
	[CreateNodeMenu("AI/Brain State")]
	public class AIBrainStateNode : Node
	{
		
		[Input(connectionType = ConnectionType.Multiple, typeConstraint = TypeConstraint.Strict)] public StateConnection statesIn;

		[Input(connectionType = ConnectionType.Multiple, typeConstraint = TypeConstraint.Strict)] public ActionConnection actions;

		[Output(connectionType = ConnectionType.Multiple)] public TransitionConnection transitions;

		protected override void Init()
		{
//			Debug.Log("test");
//			if (AIBrainGraph.StartingNode) AIBrainGraph.StartingNode = this;
		}

		public override object GetValue(NodePort port)
		{
			return null;
		}
	}
}