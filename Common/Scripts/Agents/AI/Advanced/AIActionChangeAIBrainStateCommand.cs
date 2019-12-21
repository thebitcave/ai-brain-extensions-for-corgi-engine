using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.Tools;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI
{
    /// <summary>
    /// This action sends a change state command to all registered slave brains
    /// </summary>
    public class AIActionChangeAIBrainStateCommand : AIAction
    {
        [Header("Master Brain Settings")]
        // The channel used to filter which slave should perform the action.
        public string ChannelName;

        // The state the slave should enter in.
        public string StateName;

        /// <summary>
        /// On PerformAction we send a command to all brain slaves
        /// </summary>
        public override void PerformAction()
        {
            var evt = new ChangeAIBrainStateCommandEvent(ChannelName, StateName, _brain.Target);
            MMEventManager.TriggerEvent(evt);
        }
    }
}