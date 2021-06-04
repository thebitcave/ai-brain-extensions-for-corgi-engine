using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionMMFeedbacksNode))]
    public class AIActionMMFeedbacksNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _targetFeedbacks;
        private SerializedProperty _onlyPlayWhenEnteringState;
        
        protected override void SerializeAdditionalProperties()
        {
            _targetFeedbacks = serializedObject.FindProperty("targetFeedbacks");
            _onlyPlayWhenEnteringState = serializedObject.FindProperty("onlyPlayWhenEnteringState");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_targetFeedbacks);
            EditorGUIUtility.labelWidth = 200;
            NodeEditorGUILayout.PropertyField(_onlyPlayWhenEnteringState);
            serializedObject.ApplyModifiedProperties();
        }
    }
}