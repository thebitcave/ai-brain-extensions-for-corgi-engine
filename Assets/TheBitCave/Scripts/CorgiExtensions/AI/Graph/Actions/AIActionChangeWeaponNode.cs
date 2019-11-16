using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionChangeWeapon"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Change Weapon")]
    public class AIActionChangeWeaponNode : AIActionNode
    {
        public Weapon newWeapon;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionChangeWeapon>();
            action.Label = label;
            action.NewWeapon = newWeapon;
            return action;
        }
    }
}
