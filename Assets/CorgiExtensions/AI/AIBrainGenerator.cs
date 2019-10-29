using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.CorgiEngine;
using UnityEngine;
using MoreMountains.Tools;
using UnityEngine.UIElements;

namespace TheBitCave.CorgiExensions.AI
{
    public class AIBrainGenerator : MonoBehaviour
    {

        public AIBrainGraph aiBrainGraph;

        public bool brainActive = true;

        [Header("Frequencies")]
        public float actionsFrequency = 0;
        public float decisionFrequency = 0;

        private void Start()
        {
            Cleanup();
        }

        public void Generate()
        {
            Cleanup();

            GenerateActions();
            GenerateDecisions();
            GenerateBrain();
        }

        private void GenerateDecisions()
        {
//            throw new NotImplementedException();
        }

        private void GenerateActions()
        {
//            throw new NotImplementedException();
        }

        private void GenerateBrain()
        {
            AIBrain brain = gameObject.AddComponent<AIBrain>();
            brain.BrainActive = brainActive;
            brain.ActionsFrequency = actionsFrequency;
            brain.DecisionFrequency = decisionFrequency;
        }

        private void Cleanup()
        {
            AIBrain brain = GetComponent<AIBrain>();
            Debug.Log(brain);
            DestroyImmediate(brain);

            foreach (var aiDecision in GetComponents<AIDecision>())
            {
                DestroyImmediate(aiDecision);
            }
            
            foreach (var aiAction in GetComponents<AIAction>())
            {
                DestroyImmediate(aiAction);
            }

        }

    }
}