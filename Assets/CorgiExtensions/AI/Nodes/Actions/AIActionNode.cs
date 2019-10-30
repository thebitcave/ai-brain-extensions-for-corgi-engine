using MoreMountains.Tools;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI
{
	/// <summary>
	/// A node representing a single Corgi <see cref="MoreMountains.Tools.AIAction"/>.
	/// </summary>
	[NodeWidth(250)]
	[CreateNodeMenu("")]
	public class AIActionNode : AINode
	{

		/// <summary>
		/// The Corgi Action label.
		/// </summary>
		public string label;

		[Output(connectionType = ConnectionType.Multiple)] public ActionConnection output;
		
		public virtual AIAction AddActionComponent(GameObject go)
		{
			throw new System.NotImplementedException();
		}
	}
}

