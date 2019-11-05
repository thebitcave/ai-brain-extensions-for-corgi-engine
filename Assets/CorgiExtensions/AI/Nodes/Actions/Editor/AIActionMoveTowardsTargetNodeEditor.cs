using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeEditorAttribute(typeof(AIActionMoveTowardsTargetNode))]
    public class AIActionMoveTowardsTargetNodeEditor : NodeEditor
    {
        protected SerializedProperty _label;
        protected SerializedProperty _output;
        protected SerializedProperty _minimumDistance;

        private AIActionFlyTowardsTargetNode _node;
        
        public override void OnBodyGUI()
        {
            _label = serializedObject.FindProperty("label");
            _output = serializedObject.FindProperty("output");
            _minimumDistance = serializedObject.FindProperty("minimumDistance");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_label);
            NodeEditorGUILayout.PropertyField(_output);
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_minimumDistance);
            serializedObject.ApplyModifiedProperties();
        }
    }
}