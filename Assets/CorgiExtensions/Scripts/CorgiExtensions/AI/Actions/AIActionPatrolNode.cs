using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI
{
	/// <summary>
	/// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionPatrol"/> action.
	/// </summary>
	[CreateNodeMenu("AI/Action/Patrol")]
	public class AIActionPatrolNode : AIActionNode
	{
		[Header("Obstacle Detection")]

		public bool changeDirectionOnWall = true;
		public bool avoidFalling = false;
		public Vector3 holeDetectionOffset = new Vector3(0, 0, 0);
		public float holeDetectionRaycastLength = 1f;

		public override AIAction AddActionComponent(GameObject go)
		{
			var action = go.AddComponent<AIActionPatrol>();
			action.Label = label;
			action.ChangeDirectionOnWall = changeDirectionOnWall;
			action.AvoidFalling = avoidFalling;
			action.HoleDetectionOffset = holeDetectionOffset;
			action.HoleDetectionRaycastLength = holeDetectionRaycastLength;
			return action;
		}
	}
}