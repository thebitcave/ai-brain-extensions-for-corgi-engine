using TheBitCave.MMToolsExtensions.AI;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeEditorAttribute(typeof(AIDecisionTimeSinceStartNode))]
    public class AIDecisionTimeSinceStartNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _afterTime;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _afterTime = serializedObject.FindProperty("afterTime");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_afterTime);
            serializedObject.ApplyModifiedProperties();
        }
    }
}
