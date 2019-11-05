using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeEditorAttribute(typeof(AIActionFlyTowardsTargetNode))]
    public class AIActionFlyTowardsTargetNodeEditor: AIActionNodeEditor
    {
        private SerializedProperty _minimumDistance;

        private AIActionFlyTowardsTargetNode _node;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();

            _minimumDistance = serializedObject.FindProperty("minimumDistance");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_minimumDistance);
            serializedObject.ApplyModifiedProperties();
        }
    }
}