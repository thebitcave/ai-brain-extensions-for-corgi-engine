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
        
        protected SerializedProperty _brainActive;
        protected SerializedProperty _actionsFrequency;
        protected SerializedProperty _decisionFrequency;

        private AIBrainGenerator _generator;
        
        private void OnEnable()
        {
            _generator = target as AIBrainGenerator;

            _brainActive = serializedObject.FindProperty("brainActive");
            _actionsFrequency = serializedObject.FindProperty("actionsFrequency");
            _decisionFrequency = serializedObject.FindProperty("decisionFrequency");

        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.HelpBox("Lorem Ipsum", MessageType.Info);
            
            EditorGUILayout.PropertyField(_brainActive);
            EditorGUILayout.PropertyField(_actionsFrequency);
            EditorGUILayout.PropertyField(_decisionFrequency);
            serializedObject.ApplyModifiedProperties();

            if(GUILayout.Button("Generate"))
            {
                _generator.Generate();
            }
        }
    }
}