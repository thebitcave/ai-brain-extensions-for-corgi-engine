using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionShootNode))]
    public class AIActionShootNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _faceTarget;
        private SerializedProperty _aimAtTarget;
        private SerializedProperty _targetOffset;
        
        protected override void SerializeAdditionalProperties()
        {
            _faceTarget = serializedObject.FindProperty("faceTarget");
            _aimAtTarget = serializedObject.FindProperty("aimAtTarget");
            _targetOffset = serializedObject.FindProperty("targetOffset");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_faceTarget);
            NodeEditorGUILayout.PropertyField(_aimAtTarget);
            NodeEditorGUILayout.PropertyField(_targetOffset);
            serializedObject.ApplyModifiedProperties();
        }
    }
}