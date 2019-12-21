using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionGroundedNode))]
    public class AIDecisionGroundedNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _groundedBufferDelay;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _groundedBufferDelay = serializedObject.FindProperty("groundedBufferDelay");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 140;
            NodeEditorGUILayout.PropertyField(_groundedBufferDelay);
            serializedObject.ApplyModifiedProperties();
        }
    }
}