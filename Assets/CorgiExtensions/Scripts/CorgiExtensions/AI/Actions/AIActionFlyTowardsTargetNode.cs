using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using TheBitCave.MMToolsExtensions.AI;
using UnityEngine;
using XNode;

namespace TheBitCave.CorgiExensions.AI
{
	/// <summary>
	/// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionFlyTowardsTarget"/> action.
	/// </summary>
	[CreateNodeMenu("AI/Action/Fly Towards Target")]
	public class AIActionFlyTowardsTargetNode : AIActionNode
	{

		[Header("Settings")]
		public float minimumDistance;
		
		public override AIAction AddActionComponent(GameObject go)
		{
			var action = go.AddComponent<AIActionFlyTowardsTarget>();
			action.Label = label;
			action.MinimumDistance = minimumDistance;
			return action;
		}
	}
}