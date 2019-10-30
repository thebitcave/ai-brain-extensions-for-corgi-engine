using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using MoreMountains.Tools;

namespace TheBitCave.CorgiExensions.AI
{
    /// <summary>
    /// This component generates a Corgi AI Brain system, starting from an <see cref="TheBitCave.CorgiExensions.AI.AIBrainGraph"/> asset.
    /// </summary>
    public class AIBrainGenerator : MonoBehaviour
    {

        /// <summary>
        /// The brain asset.
        /// </summary>
        public AIBrainGraph aiBrainGraph;

        [Header("Brain Settings")]
        public bool brainActive = true;

        [Space]
        /// The <see cref="MoreMountains.Tools.AIBrain"/> frequency (in seconds) at which to perform actions (lower values : higher frequency, high values : lower frequency but better performance)
        public float actionsFrequency = 0;
        /// The <see cref="MoreMountains.Tools.AIBrain"/> frequency (in seconds) at which to evaluate decisions
        public float decisionFrequency = 0;

        private Dictionary<AIDecisionNode, AIDecision> _decisions;
        private Dictionary<AIActionNode, AIAction> _actions;
        
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
            // Removes all Corgi Brain, Action and Decision components
            Cleanup();

            _decisions = new Dictionary<AIDecisionNode, AIDecision>();
            _actions = new Dictionary<AIActionNode, AIAction>();
            
            // Starts the generation process
            GenerateActions();
            GenerateDecisions();
            GenerateBrain();
        }

        /// <summary>
        /// Generates all <see cref="MoreMountains.Tools.AIDecision"/> components attaching them to the gameObject.
        /// </summary>
        private void GenerateDecisions()
        {
            foreach (var decisionNode in aiBrainGraph.nodes.OfType<AIDecisionNode>()
                .Select(node => (node as AIDecisionNode)))
            {
                var aiDecision =  decisionNode.AddDecisionComponent(gameObject);
                _decisions.Add(decisionNode, aiDecision);
            }
        }

        /// <summary>
        /// Generates all <see cref="MoreMountains.Tools.AIAction"/> components attaching them to the gameObject.
        /// </summary>
        private void GenerateActions()
        {
            foreach (var actionNode in aiBrainGraph.nodes.OfType<AIActionNode>()
                .Select(node => (node as AIActionNode)))
            {
                var aiAction =  actionNode.AddActionComponent(gameObject);
                _actions.Add(actionNode, aiAction);
            }
        }

        /// <summary>
        /// Generates the <see cref="MoreMountains.Tools.AIBrain"/> component creating all
        /// corresponding logic.
        /// </summary>
        private void GenerateBrain()
        {
            // Create the brain
            var brain = gameObject.AddComponent<AIBrain>();
            brain.BrainActive = brainActive;
            brain.ActionsFrequency = actionsFrequency;
            brain.DecisionFrequency = decisionFrequency;
            brain.States = new List<AIState>();

            // Get all states and initialize them
            foreach (var brainStateNode in aiBrainGraph.nodes.OfType<AIBrainStateNode>()
                .Select(node => (node as AIBrainStateNode)))
            {
                var aiState = new AIState
                {
                    StateName = brainStateNode.name,
                    Transitions = new AITransitionsList(),
                    Actions = new AIActionsList()
                };
                if (AIBrainStateNode.StartingNode == brainStateNode)
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
        public void Cleanup()
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