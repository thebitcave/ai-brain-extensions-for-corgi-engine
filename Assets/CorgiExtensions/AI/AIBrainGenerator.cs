using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MoreMountains.CorgiEngine;
using UnityEngine;
using MoreMountains.Tools;

namespace TheBitCave.CorgiExensions.AI
{
    public class AIBrainGenerator : MonoBehaviour
    {

        public AIBrainGraph aiBrainGraph;

        public bool brainActive = true;

        [Header("Frequencies")]
        public float actionsFrequency = 0;
        public float decisionFrequency = 0;

        protected Dictionary<DecisionNode, AIDecision> _decisions;
        protected Dictionary<ActionNode, AIAction> _actions;
        
        private void Start()
        {
            Cleanup();
        }

        public void Generate()
        {
            Cleanup();

            _decisions = new Dictionary<DecisionNode, AIDecision>();
            _actions = new Dictionary<ActionNode, AIAction>();
            
            GenerateActions();
            GenerateDecisions();
            GenerateBrain();
        }

        private void GenerateDecisions()
        {
            foreach (var decision in aiBrainGraph.nodes.OfType<DecisionNode>()
                .Select(node => (node as DecisionNode).AddDecisionComponent(gameObject)))
            {
            }
        }

        private void GenerateActions()
        {
            foreach (var action in aiBrainGraph.nodes.OfType<ActionNode>()
                .Select(node => (node as ActionNode).AddActionComponent(gameObject)))
            {
            }
        }

        private void GenerateBrain()
        {
            var brain = gameObject.AddComponent<AIBrain>();
            brain.BrainActive = brainActive;
            brain.ActionsFrequency = actionsFrequency;
            brain.DecisionFrequency = decisionFrequency;
        }

        private void Cleanup()
        {
            var brain = GetComponent<AIBrain>();
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