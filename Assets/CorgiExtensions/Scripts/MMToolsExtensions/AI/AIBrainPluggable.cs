using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using UnityEngine;

namespace TheBitCave.MMToolsExtensions.AI
{
    /// <summary>
    /// A subclass to the regular Corgi Corgi <see cref="MoreMountains.Tools.AIBrain"/> used
    /// for runtime generation.
    /// </summary>
    [AddComponentMenu("Corgi Extensions/AI/AI Brain Pluggable")] 
    public class AIBrainPluggable : AIBrain
    {
        /// <summary>
        /// The brain asset.
        /// </summary>
        [Header("Pluggable Brain")]
        public AIBrainGraph[] aiBrainGraphs;

        /// <summary>
        /// On awake we set our brain for all states
        /// </summary>
        protected override void Awake()
        {
            // The brain graph is mandatory
            if (aiBrainGraphs.Length == 0)
            {
                Debug.LogError(C.ERROR_NO_AI_BRAIN);
                return;
            }

            // Starts the generation process
            AIBrainGraph graph = aiBrainGraphs[Random.Range(0, aiBrainGraphs.Length)];
            var generator = new GraphToBrainGenerator(graph, gameObject);
            generator.GeneratePluggable(this);

            base.Awake();
        }
    }
}