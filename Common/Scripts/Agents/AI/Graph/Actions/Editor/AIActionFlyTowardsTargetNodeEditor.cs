using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionFlyTowardsTargetNode))]
    public class AIActionFlyTowardsTargetNodeEditor: AIActionNodeEditor
    {
        private SerializedProperty _minimumDistance;

        private AIActionFlyTowardsTargetNode _node;
        
        protected override void SerializeAdditionalProperties()
        {
            _minimumDistance = serializedObject.FindProperty("minimumDistance");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_minimumDistance);
            serializedObject.ApplyModifiedProperties();
        }
    }
}