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

        private Dictionary<DecisionNode, AIDecision> _decisions;
        private Dictionary<ActionNode, AIAction> _actions;
        private Dictionary<string, BrainStateNode> _brainStates;
        
        private void Start()
        {
            Cleanup();
        }

        public void Generate()
        {
            Cleanup();

            _decisions = new Dictionary<DecisionNode, AIDecision>();
            _actions = new Dictionary<ActionNode, AIAction>();
            _brainStates = new Dictionary<string, BrainStateNode>();
            
            GenerateActions();
            GenerateDecisions();
            GenerateBrain();
        }

        private void GenerateDecisions()
        {
            foreach (var decisionNode in aiBrainGraph.nodes.OfType<DecisionNode>()
                .Select(node => (node as DecisionNode)))
            {
                var aiDecision =  decisionNode.AddDecisionComponent(gameObject);
                _decisions.Add(decisionNode, aiDecision);
            }
        }

        private void GenerateActions()
        {
            foreach (var actionNode in aiBrainGraph.nodes.OfType<ActionNode>()
                .Select(node => (node as ActionNode)))
            {
                var aiAction =  actionNode.AddActionComponent(gameObject);
                _actions.Add(actionNode, aiAction);
            }
        }

        private void GenerateBrain()
        {
            var brain = gameObject.AddComponent<AIBrain>();
            brain.BrainActive = brainActive;
            brain.ActionsFrequency = actionsFrequency;
            brain.DecisionFrequency = decisionFrequency;
            brain.States = new List<AIState>();

            foreach (var brainStateNode in aiBrainGraph.nodes.OfType<BrainStateNode>()
                .Select(node => (node as BrainStateNode)))
            {
                _brainStates.Add(brainStateNode.name, brainStateNode);
                var aiState = new AIState
                {
                    StateName = brainStateNode.name
                };
                brain.States.Add(aiState);
            }
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