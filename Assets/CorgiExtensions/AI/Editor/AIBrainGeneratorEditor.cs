using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomEditor (typeof(AIBrainGenerator))]
    public class AIBrainGeneratorEditor : Editor
    {
        
        protected SerializedProperty _aiBrainGraph;

        protected SerializedProperty _brainActive;
        protected SerializedProperty _actionsFrequency;
        protected SerializedProperty _decisionFrequency;

        private AIBrainGenerator _generator;
        
        private void OnEnable()
        {
            _generator = target as AIBrainGenerator;

            _aiBrainGraph = serializedObject.FindProperty("aiBrainGraph");
            
            _brainActive = serializedObject.FindProperty("brainActive");
            _actionsFrequency = serializedObject.FindProperty("actionsFrequency");
            _decisionFrequency = serializedObject.FindProperty("decisionFrequency");

        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(_aiBrainGraph);
            EditorGUILayout.Space();
            EditorGUILayout.PropertyField(_brainActive);
            EditorGUILayout.PropertyField(_actionsFrequency);
            EditorGUILayout.PropertyField(_decisionFrequency);
            serializedObject.ApplyModifiedProperties();

            EditorGUILayout.HelpBox("Generating the AI will remove all AI Brain, Action and Decision scripts present attached to this gameobject!", MessageType.Warning);
            
            if(GUILayout.Button("Generate"))
            {
                _generator.Generate();
            }
            
            if(GUILayout.Button("Remove AI Scripts"))
            {
                _generator.Cleanup();
            }

        }
    }
}