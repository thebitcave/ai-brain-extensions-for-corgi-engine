using System;
using UnityEngine;
using XNode;

namespace TheBitCave.CorgiExensions.AI
{
	/// <summary>
	/// A Graph to create AI Brains for the Corgi <see cref="MoreMountains.Tools.AIBrain"/>.
	/// </summary>
	[Serializable, CreateAssetMenu(fileName = "New Brain Graph", menuName = "Corgi AI/Brain Graph")]
	public class AIBrainGraph : NodeGraph
	{ 
	}	
}
