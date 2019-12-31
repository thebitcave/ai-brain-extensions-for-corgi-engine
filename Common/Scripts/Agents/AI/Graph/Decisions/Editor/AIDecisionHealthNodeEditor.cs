using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionHealthNode))]
    public class AIDecisionHealthNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _trueIfHealthIs;
        private SerializedProperty _healthValue;
        private SerializedProperty _onlyOnce;
        
        protected override void SerializeAdditionalProperties()
        {
            _trueIfHealthIs = serializedObject.FindProperty("trueIfHealthIs");
            _healthValue = serializedObject.FindProperty("healthValue");
            _onlyOnce = serializedObject.FindProperty("onlyOnce");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_trueIfHealthIs);
            NodeEditorGUILayout.PropertyField(_healthValue);
            NodeEditorGUILayout.PropertyField(_onlyOnce);
            serializedObject.ApplyModifiedProperties();
        }
    }
}