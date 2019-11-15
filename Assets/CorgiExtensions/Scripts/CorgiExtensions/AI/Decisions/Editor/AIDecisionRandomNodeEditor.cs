using TheBitCave.MMToolsExtensions.AI;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeEditorAttribute(typeof(AIDecisionRandomNode))]
    public class AIDecisionRandomNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _totalChance;
        private SerializedProperty _odds;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _totalChance = serializedObject.FindProperty("totalChance");
            _odds = serializedObject.FindProperty("odds");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_totalChance);
            NodeEditorGUILayout.PropertyField(_odds);
            serializedObject.ApplyModifiedProperties();
        }
    }
}