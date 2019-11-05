using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeEditorAttribute(typeof(AIActionJumpNode))]
    public class AIActionJumpNodeEditor : NodeEditor
    {
        protected SerializedProperty _label;
        protected SerializedProperty _output;
        protected SerializedProperty _numberOfJumps;

        private AIActionFlyTowardsTargetNode _node;
        
        public override void OnBodyGUI()
        {
            _label = serializedObject.FindProperty("label");
            _output = serializedObject.FindProperty("output");
            _numberOfJumps = serializedObject.FindProperty("numberOfJumps");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_label);
            NodeEditorGUILayout.PropertyField(_output);
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_numberOfJumps);
            serializedObject.ApplyModifiedProperties();
        }
    }
}