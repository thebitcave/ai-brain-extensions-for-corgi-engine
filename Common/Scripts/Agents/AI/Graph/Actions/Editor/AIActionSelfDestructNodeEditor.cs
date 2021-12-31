using MoreMountains.CorgiEngine;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionSelfDestructNode))]
    public class AIActionSelfDestructNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _onlyRunOnce;
        
        protected override void SerializeAdditionalProperties()
        {
            _onlyRunOnce = serializedObject.FindProperty("onlyRunOnce");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 200;
            NodeEditorGUILayout.PropertyField(_onlyRunOnce);
            serializedObject.ApplyModifiedProperties();
        }
    }
}