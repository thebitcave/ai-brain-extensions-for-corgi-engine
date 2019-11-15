using TheBitCave.MMToolsExtensions.AI;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeEditorAttribute(typeof(AIActionShootNode))]
    public class AIActionShootNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _faceTarget;
        private SerializedProperty _aimAtTarget;
        private SerializedProperty _targetOffset;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
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