using TheBitCave.MMToolsExtensions.AI;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeEditorAttribute(typeof(AIDecisionLineOfSightToTargetNode))]
    public class AIDecisionLineOfSightToTargetNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _obstacleLayerMask;
        private SerializedProperty _lineOfSightOffset;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _obstacleLayerMask = serializedObject.FindProperty("obstacleLayerMask");
            _lineOfSightOffset = serializedObject.FindProperty("lineOfSightOffset");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 140;
            NodeEditorGUILayout.PropertyField(_obstacleLayerMask);
            NodeEditorGUILayout.PropertyField(_lineOfSightOffset);
            serializedObject.ApplyModifiedProperties();
        }
    }
}