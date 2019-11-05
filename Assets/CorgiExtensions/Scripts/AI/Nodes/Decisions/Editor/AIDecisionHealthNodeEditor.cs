using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeEditorAttribute(typeof(AIDecisionHealthNode))]
    public class AIDecisionHealthNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _trueIfHealthIs;
        private SerializedProperty _healthValue;
        private SerializedProperty _onlyOnce;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
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