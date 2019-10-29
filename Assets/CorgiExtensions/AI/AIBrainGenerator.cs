using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MoreMountains.CorgiEngine;
using UnityEngine;
using MoreMountains.Tools;
using XNode;

namespace TheBitCave.CorgiExensions.AI
{
    public class AIBrainGenerator : MonoBehaviour
    {

        public AIBrainGraph aiBrainGraph;

        public bool brainActive = true;

        [Header("Frequencies")]
        public float actionsFrequency = 0;
        public float decisionFrequency = 0;

        private Dictionary<AIDecisionNode, AIDecision> _decisions;
        private Dictionary<AIActionNode, AIAction> _actions;
        private Dictionary<string, AIBrainStateNode> _brainStates;
        
        private void Start()
        {
            Cleanup();
        }

        public void Generate()
        {
            Cleanup();

            _decisions = new Dictionary<AIDecisionNode, AIDecision>();
            _actions = new Dictionary<AIActionNode, AIAction>();
            _brainStates = new Dictionary<string, AIBrainStateNode>();
            
            GenerateActions();
            GenerateDecisions();
            GenerateBrain();
        }

        private void GenerateDecisions()
        {
            foreach (var decisionNode in aiBrainGraph.nodes.OfType<AIDecisionNode>()
                .Select(node => (node as AIDecisionNode)))
            {
                var aiDecision =  decisionNode.AddDecisionComponent(gameObject);
                _decisions.Add(decisionNode, aiDecision);
            }
        }

        private void GenerateActions()
        {
            foreach (var actionNode in aiBrainGraph.nodes.OfType<AIActionNode>()
                .Select(node => (node as AIActionNode)))
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

            foreach (var brainStateNode in aiBrainGraph.nodes.OfType<AIBrainStateNode>()
                .Select(node => (node as AIBrainStateNode)))
            {
                _brainStates.Add(brainStateNode.name, brainStateNode);
                var aiState = new AIState
                {
                    StateName = brainStateNode.name,
                    Transitions = new AITransitionsList(),
                    Actions = new AIActionsList()
                };
                if (brainStateNode.defaultState)
                {
                    brain.States.Insert(0, aiState);                    
                }
                else
                {
                    brain.States.Add(aiState);
                }

                var decisionPort = brainStateNode.GetOutputPort(C.PORT_DECISIONS);
                foreach (var decisionNode in decisionPort.GetConnections().Select(connection => connection.node).OfType<AIDecisionNode>())
                {
                    _decisions.TryGetValue(decisionNode, out var decisionComponent);
                    var transition = new AITransition
                    {
                        Decision = decisionComponent,
                        TrueState = decisionNode.GetTrueStateLabel(),
                        FalseState = decisionNode.GetFalseStateLabel()
                    };
                    aiState.Transitions.Add(transition);
                }

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