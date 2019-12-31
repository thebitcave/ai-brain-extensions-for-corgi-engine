using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionTimeInStateNode))]
    public class AIDecisionTimeInStateNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _afterTimeMin;
        private SerializedProperty _afterTimeMax;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            if (CollapseNodeOn) return;

            _afterTimeMin = serializedObject.FindProperty("afterTimeMin");
            _afterTimeMax = serializedObject.FindProperty("afterTimeMax");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_afterTimeMin);
            NodeEditorGUILayout.PropertyField(_afterTimeMax);
            serializedObject.ApplyModifiedProperties();
        }
    }
}