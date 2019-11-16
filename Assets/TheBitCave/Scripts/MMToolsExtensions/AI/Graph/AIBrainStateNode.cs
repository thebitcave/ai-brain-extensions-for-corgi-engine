using System;
using UnityEditor;
using UnityEngine;
using XNode;

namespace TheBitCave.MMToolsExtensions.AI.Graph
{
	/// <summary>
	/// A node representing a single state in the Corgi <see cref="MoreMountains.Tools.AIBrain"/>.
	/// </summary>
	[NodeTint("#E63946")]
	[CreateNodeMenu("AI/Brain State")]
	[NodeWidth(180)]
	public class AIBrainStateNode : AINode
	{
		
		/// <summary>
		/// Input states (i.e.: where we came from?)
		/// </summary>
		[Input(connectionType = ConnectionType.Multiple, typeConstraint = TypeConstraint.Strict)] public StateConnection statesIn;

		/// <summary>
		/// Actions to be performed when entering this state
		/// </summary>
		[Input(connectionType = ConnectionType.Multiple, typeConstraint = TypeConstraint.Strict)] public ActionConnection actions;

		/// <summary>
		/// Transitions to exit this state
		/// </summary>
		[Output(connectionType = ConnectionType.Multiple)] public TransitionConnection transitions;

	}
}