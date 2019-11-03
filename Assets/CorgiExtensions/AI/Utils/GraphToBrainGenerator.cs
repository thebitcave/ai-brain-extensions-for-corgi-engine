using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MoreMountains.Tools;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI
{
    public class GraphToBrainGenerator
    {
        private readonly AIBrainGraph _aiBrainGraph;
        private readonly GameObject _gameObject;
        private Dictionary<AIDecisionNode, AIDecision> _decisions;
        private Dictionary<AIActionNode, AIAction> _actions;

        public GraphToBrainGenerator(AIBrainGraph graph, GameObject go)
        {
            _aiBrainGraph = graph;
            _gameObject = go;
        }
        
        /// <summary>
        /// Generates the <see cref="MoreMountains.Tools.AIBrain"/> system components (Brain, Actions and Decisions)
        /// as defined in the brain graph asset.
        /// </summary>
        public void Generate(bool brainActive, float actionsFrequency, float decisionFrequency)
        {
            // Removes all Corgi Brain, Action and Decision components
            Cleanup(_gameObject);

            _decisions = new Dictionary<AIDecisionNode, AIDecision>();
            _actions = new Dictionary<AIActionNode, AIAction>();
            
            // Starts the generation process
            GenerateActions();
            GenerateDecisions();
            GenerateBrain(brainActive, actionsFrequency, decisionFrequency);
        }

        public void GeneratePluggable(AIBrain brain)
        {
            // Removes all Corgi Brain, Action and Decision components
            Cleanup(_gameObject, true);

            _decisions = new Dictionary<AIDecisionNode, AIDecision>();
            _actions = new Dictionary<AIActionNode, AIAction>();
            
            // Starts the generation process
            GenerateActions();
            GenerateDecisions();
            InitBrain(brain);
        }

        /// <summary>
        /// Generates all <see cref="MoreMountains.Tools.AIDecision"/> components attaching them to the gameObject.
        /// </summary>
        private void GenerateDecisions()
        {
            foreach (var decisionNode in _aiBrainGraph.nodes.OfType<AIDecisionNode>()
                .Select(node => (node as AIDecisionNode)))
            {
                var aiDecision =  decisionNode.AddDecisionComponent(_gameObject);
                _decisions.Add(decisionNode, aiDecision);
            }
        }

        /// <summary>
        /// Generates all <see cref="MoreMountains.Tools.AIAction"/> components attaching them to the gameObject.
        /// </summary>
        private void GenerateActions()
        {
            foreach (var actionNode in _aiBrainGraph.nodes.OfType<AIActionNode>()
                .Select(node => (node as AIActionNode)))
            {
                var aiAction =  actionNode.AddActionComponent(_gameObject);
                _actions.Add(actionNode, aiAction);
            }
        }

        /// <summary>
        /// Generates the <see cref="MoreMountains.Tools.AIBrain"/> component creating all
        /// corresponding logic.
        /// </summary>
        private void GenerateBrain(bool brainActive, float actionsFrequency, float decisionFrequency)
        {
            // Create the brain
            var brain = _gameObject.AddComponent<AIBrain>();
            brain.BrainActive = brainActive;
            brain.ActionsFrequency = actionsFrequency;
            brain.DecisionFrequency = decisionFrequency;
            
            InitBrain(brain);
        }
        
        private void InitBrain(AIBrain brain)
        {
            brain.States = new List<AIState>();
            List<string> stateNames = new List<string>();

            // Get all states and initialize them
            foreach (var brainStateNode in _aiBrainGraph.nodes.OfType<AIBrainStateNode>()
                .Select(node => (node as AIBrainStateNode)))
            {
                if (stateNames.IndexOf(brainStateNode.name) >= 0)
                {
                    Debug.LogError(C.ERROR_DUPLICATE_STATE_KEYS);
                    return;
                }
                stateNames.Add(brainStateNode.name);
                var aiState = new AIState
                {
                    StateName = brainStateNode.name,
                    Transitions = new AITransitionsList(),
                    Actions = new AIActionsList()
                };
                var graph = brainStateNode.graph as AIBrainGraph;
                if (graph != null && graph.startingNode == brainStateNode)
                {
                    brain.States.Insert(0, aiState);                    
                }
                else
                {
                    brain.States.Add(aiState);
                }

                // Sets all decisions logic
                var transitionsPort = brainStateNode.GetOutputPort(C.PORT_TRANSITIONS);
                foreach (var transitionNode in transitionsPort.GetConnections().Select(connection => connection.node).OfType<AITransitionNode>())
                {
                    _decisions.TryGetValue(transitionNode.GetDecision(), out var decisionComponent);
                    var transition = new AITransition
                    {
                        Decision = decisionComponent,
                        TrueState = transitionNode.GetTrueStateLabel(),
                        FalseState = transitionNode.GetFalseStateLabel()
                    };
                    aiState.Transitions.Add(transition);
                }

                // Sets all actions logic
                var actionPort = brainStateNode.GetInputPort(C.PORT_ACTIONS);
                foreach (var actionNode in actionPort.GetConnections().Select(connection => connection.node).OfType<AIActionNode>())
                {
                    _actions.TryGetValue(actionNode, out var actionComponent);
                    aiState.Actions.Add(actionComponent);
                }
            }
        }

        /// <summary>
        /// Removes all Corgi Brain, Actions and Decisions from the gameObject.
        /// </summary>
        public static void Cleanup(GameObject go, bool excludeBrain = false)
        {
            foreach (var aiDecision in go.GetComponents<AIDecision>())
            {
                Object.DestroyImmediate(aiDecision);
            }
            
            foreach (var aiAction in go.GetComponents<AIAction>())
            {
                Object.DestroyImmediate(aiAction);
            }

            if (excludeBrain) return;
            
            var brain = go.GetComponent<AIBrain>();
            Object.DestroyImmediate(brain);
        }

    }
}