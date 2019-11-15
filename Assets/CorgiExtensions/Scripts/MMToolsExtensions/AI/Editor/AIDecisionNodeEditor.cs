using UnityEditor;
using XNodeEditor;

namespace TheBitCave.MMToolsExtensions.AI
{
    [CustomNodeEditorAttribute(typeof(AIDecisionNode))]
    public class AIDecisionNodeEditor : NodeEditor
    {
        private SerializedProperty _label;
        private SerializedProperty _output;
        
        public override void OnBodyGUI()
        {
            _label = serializedObject.FindProperty("label");
            _output = serializedObject.FindProperty("output");
            
            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_label);
            NodeEditorGUILayout.PropertyField(_output);
            serializedObject.ApplyModifiedProperties();
        }

    }
}