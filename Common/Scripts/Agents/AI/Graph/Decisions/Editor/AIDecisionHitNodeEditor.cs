using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionHitNode))]
    public class AIDecisionHitNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _numberOfHits;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _numberOfHits = serializedObject.FindProperty("numberOfHits");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_numberOfHits);
            serializedObject.ApplyModifiedProperties();
        }
    }
}