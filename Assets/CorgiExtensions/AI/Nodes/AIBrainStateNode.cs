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
		public static AIBrainStateNode StartingNode;
		
		[Input(connectionType = ConnectionType.Multiple, typeConstraint = TypeConstraint.Strict)] public TransitionConnection transitionsIn;

		[Input(connectionType = ConnectionType.Multiple, typeConstraint = TypeConstraint.Strict)] public ActionConnection actions;

		[Output(connectionType = ConnectionType.Multiple)] public DecisionConnection decisions;

		protected override void Init()
		{
		//	if (!StartingNode) StartingNode = this;
		}

		public override object GetValue(NodePort port)
		{
			return null;
		}
	}
}