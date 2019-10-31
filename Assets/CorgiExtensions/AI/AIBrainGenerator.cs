using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using MoreMountains.Tools;

namespace TheBitCave.CorgiExensions.AI
{
    /// <summary>
    /// This component generates a Corgi AI Brain system, starting from an <see cref="TheBitCave.CorgiExensions.AI.AIBrainGraph"/> asset.
    /// </summary>
    [AddComponentMenu("Corgi Extensions/AI/AI Brain Generator")] 
    public class AIBrainGenerator : MonoBehaviour
    {
        /// <summary>
        /// The brain asset.
        /// </summary>
        public AIBrainGraph aiBrainGraph;

        [Header("Brain Settings")]
        public bool brainActive = true;
        
        /// The <see cref="MoreMountains.Tools.AIBrain"/> frequency (in seconds) at which to perform actions (lower values : higher frequency, high values : lower frequency but better performance)
        [Space]
        public float actionsFrequency = 0;
        
        /// The <see cref="MoreMountains.Tools.AIBrain"/> frequency (in seconds) at which to evaluate decisions
        public float decisionFrequency = 0;

        private GraphToBrainGenerator _generator;
        
        /// <summary>
        /// Generates the <see cref="MoreMountains.Tools.AIBrain"/> system components (Brain, Actions and Decisions)
        /// as defined in the brain graph asset.
        /// </summary>
        public void Generate()
        {
            // The brain graph is mandatory
            if (aiBrainGraph == null)
            {
                Debug.LogError(C.ERROR_NO_AI_BRAIN);
                return;
            }

            // Starts the generation process
            _generator = new GraphToBrainGenerator(aiBrainGraph, gameObject);
            _generator.Generate(brainActive, actionsFrequency, decisionFrequency);
        }

        public void Cleanup()
        {
            GraphToBrainGenerator.Cleanup(gameObject);
        }
    }
}