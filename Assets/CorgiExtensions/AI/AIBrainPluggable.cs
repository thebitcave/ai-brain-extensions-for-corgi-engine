using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI
{
    /// <summary>
    /// A subclass to the regular Corgi Corgi <see cref="MoreMountains.Tools.AIBrain"/> used
    /// for runtime generation.
    /// </summary>
    public class AIBrainPluggable : AIBrain
    {
        /// <summary>
        /// The brain asset.
        /// </summary>
        [Header("Pluggable Brain")]
        public AIBrainGraph aiBrainGraph;

        /// <summary>
        /// On awake we set our brain for all states
        /// </summary>
        protected override void Awake()
        {
            // The brain graph is mandatory
            if (aiBrainGraph == null)
            {
                Debug.LogError(C.ERROR_NO_AI_BRAIN);
                return;
            }

            // Starts the generation process
            var generator = new GraphToBrainGenerator(aiBrainGraph, gameObject);
            generator.GeneratePluggable(this);

            base.Awake();
        }
    }
}