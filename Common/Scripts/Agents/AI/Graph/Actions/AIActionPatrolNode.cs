using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI.Graph
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

		public bool useCustomLayermask = false;
		
		public LayerMask obstaclesLayermask = LayerManager.ObstaclesLayerMask;
		public float obstaclesDetectionRaycastLength = 0.5f;
		public Vector2 obstaclesDetectionRaycastOrigin = new Vector2(0.5f, 0f);
		
		public bool resetPositionOnDeath = true;

		public override AIAction AddActionComponent(GameObject go)
		{
			var action = go.AddComponent<AIActionPatrol>();
			action.Label = label;
			action.ChangeDirectionOnWall = changeDirectionOnWall;
			action.AvoidFalling = avoidFalling;
			action.HoleDetectionOffset = holeDetectionOffset;
			action.HoleDetectionRaycastLength = holeDetectionRaycastLength;

			action.UseCustomLayermask = useCustomLayermask;
			action.ObstaclesLayermask = obstaclesLayermask;
			action.ObstaclesDetectionRaycastLength = obstaclesDetectionRaycastLength;
			action.ObstaclesDetectionRaycastOrigin = obstaclesDetectionRaycastOrigin;

			action.ResetPositionOnDeath = resetPositionOnDeath;
			
			return action;
		}
	}
}