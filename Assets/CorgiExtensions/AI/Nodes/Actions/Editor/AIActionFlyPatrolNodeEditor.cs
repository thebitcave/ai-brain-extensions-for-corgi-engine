using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeEditorAttribute(typeof(AIActionFlyPatrolNode))]
    public class AIActionFlyPatrolNodeEditor : NodeEditor
    {
        protected SerializedProperty _label;
        protected SerializedProperty _output;
        protected SerializedProperty _changeDirectionOnObstacle;

        public override void OnBodyGUI()
        {
            _label = serializedObject.FindProperty("label");
            _output = serializedObject.FindProperty("output");
            _changeDirectionOnObstacle = serializedObject.FindProperty("changeDirectionOnObstacle");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_label);
            NodeEditorGUILayout.PropertyField(_output);
            EditorGUIUtility.labelWidth = 170;
            NodeEditorGUILayout.PropertyField(_changeDirectionOnObstacle);
            serializedObject.ApplyModifiedProperties();
        }
    }
}