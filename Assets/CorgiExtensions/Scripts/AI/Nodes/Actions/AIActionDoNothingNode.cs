using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using UnityEngine;
using XNode;

namespace TheBitCave.CorgiExensions.AI
{
	/// <summary>
	/// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionDoNothing"/> action.
	/// </summary>
	[CreateNodeMenu("AI/Action/Do Nothing")]
	public class AIActionDoNothingNode : AIActionNode
	{

		public override AIAction AddActionComponent(GameObject go)
		{
			var action = go.AddComponent<AIActionDoNothing>();
			action.Label = label;
			return action;
		}

	}
	
}
