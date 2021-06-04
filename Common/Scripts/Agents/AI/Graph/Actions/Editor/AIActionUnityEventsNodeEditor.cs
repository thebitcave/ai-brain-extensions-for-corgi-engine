using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionUnityEventsNode))]
    public class AIActionUnityEventsNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _targetEvent;
        private SerializedProperty _onlyPlayWhenEnteringState;
        
        protected override void SerializeAdditionalProperties()
        {
            _targetEvent = serializedObject.FindProperty("targetEvent");
            _onlyPlayWhenEnteringState = serializedObject.FindProperty("onlyPlayWhenEnteringState");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_targetEvent);
            EditorGUIUtility.labelWidth = 200;
            NodeEditorGUILayout.PropertyField(_onlyPlayWhenEnteringState);
            serializedObject.ApplyModifiedProperties();
        }
    }
}