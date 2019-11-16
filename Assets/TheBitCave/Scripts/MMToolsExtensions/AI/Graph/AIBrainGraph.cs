using System;
using UnityEngine;
using XNode;

namespace TheBitCave.MMToolsExtensions.AI.Graph
{
	/// <summary>
	/// A Graph to create AI Brains for the Corgi <see cref="MoreMountains.Tools.AIBrain"/>.
	/// </summary>
	[Serializable, CreateAssetMenu(fileName = "New Brain Graph", menuName = "The Bit Cave/AI Brain Graph for Corgi")]
	public class AIBrainGraph : NodeGraph
	{
		/// <summary>
		/// Which state should be initialized as the starting one.
		/// </summary>
		public AIBrainStateNode startingNode;

	}	
}
