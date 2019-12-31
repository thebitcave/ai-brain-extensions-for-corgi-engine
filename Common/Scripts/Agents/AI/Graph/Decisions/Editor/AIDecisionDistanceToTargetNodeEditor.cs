using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionDistanceToTargetNode))]
    public class AIDecisionDistanceToTargetNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _comparisonMode;
        private SerializedProperty _distance;
        
        protected override void SerializeAdditionalProperties()
        {
            _comparisonMode = serializedObject.FindProperty("comparisonMode");
            _distance = serializedObject.FindProperty("distance");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_comparisonMode);
            NodeEditorGUILayout.PropertyField(_distance);
            serializedObject.ApplyModifiedProperties();
        }

    }
}