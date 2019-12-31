using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionRandomNode))]
    public class AIDecisionRandomNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _totalChance;
        private SerializedProperty _odds;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            if (CollapseNodeOn) return;

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