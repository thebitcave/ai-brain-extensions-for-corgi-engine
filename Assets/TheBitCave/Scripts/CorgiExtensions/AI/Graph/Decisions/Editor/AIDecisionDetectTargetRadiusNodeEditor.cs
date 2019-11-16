using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionDetectTargetRadiusNode))]
    public class AIDecisionDetectTargetRadiusNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _radius;
        private SerializedProperty _detectionOriginOffset;
        private SerializedProperty _targetLayer;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _radius = serializedObject.FindProperty("radius");
            _detectionOriginOffset = serializedObject.FindProperty("detectionOriginOffset");
            _targetLayer = serializedObject.FindProperty("targetLayer");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_radius);
            NodeEditorGUILayout.PropertyField(_detectionOriginOffset);
            NodeEditorGUILayout.PropertyField(_targetLayer);
            serializedObject.ApplyModifiedProperties();
        }
    }
}