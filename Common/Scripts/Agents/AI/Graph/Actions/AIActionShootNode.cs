using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIActionShoot"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Shoot")]
    public class AIActionShootNode : AIActionNode
    {
        public bool faceTarget = true;
        public bool aimAtTarget = false;
        public Vector3 targetOffset = Vector3.zero;
        public CharacterHandleWeapon targetHandleWeapon;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionShoot>();
            action.Label = label;
            action.FaceTarget = faceTarget;
            action.AimAtTarget = aimAtTarget;
            action.TargetOffset = targetOffset;
            action.TargetHandleWeapon = targetHandleWeapon;
            return action;
        }
    }
}