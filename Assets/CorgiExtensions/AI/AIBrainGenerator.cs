using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using MoreMountains.Tools;

namespace TheBitCave.CorgiExensions.AI
{
    public class AIBrainGenerator : MonoBehaviour
    {

        public AIBrainGraph aiBrainGraph;

        [Header("Brain Settings")]
        public bool brainActive = true;

        [Space]
        public float actionsFrequency = 0;
        public float decisionFrequency = 0;

        private Dictionary<AIDecisionNode, AIDecision> _decisions;
        private Dictionary<AIActionNode, AIAction> _actions;
        
        public void Generate()
        {
            if (aiBrainGraph == null)
            {
                Debug.LogError(C.ERROR_NO_AI_BRAIN);
                return;
            }
            Cleanup();

            _decisions = new Dictionary<AIDecisionNode, AIDecision>();
            _actions = new Dictionary<AIActionNode, AIAction>();
            
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
                var aiState = new AIState
                {
                    StateName = brainStateNode.name,
                    Transitions = new AITransitionsList(),
                    Actions = new AIActionsList()
                };
                if (AIBrainGraph.StartingNode == brainStateNode)
                {
                    brain.States.Insert(0, aiState);                    
                }
                else
                {
                    brain.States.Add(aiState);
                }

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

                var actionPort = brainStateNode.GetInputPort(C.PORT_ACTIONS);
                foreach (var actionNode in actionPort.GetConnections().Select(connection => connection.node).OfType<AIActionNode>())
                {
                    _actions.TryGetValue(actionNode, out var actionComponent);
                    aiState.Actions.Add(actionComponent);
                }
            }
        }

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