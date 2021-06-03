using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionFlyPatrolNode))]
    public class AIActionFlyPatrolNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _changeDirectionOnObstacle;

        private SerializedProperty _resetPositionOnDeath;

        protected override void SerializeAdditionalProperties()
        {
            _changeDirectionOnObstacle = serializedObject.FindProperty("changeDirectionOnObstacle");
            _resetPositionOnDeath = serializedObject.FindProperty("resetPositionOnDeath");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 170;
            NodeEditorGUILayout.PropertyField(_changeDirectionOnObstacle);
            NodeEditorGUILayout.PropertyField(_resetPositionOnDeath);
            serializedObject.ApplyModifiedProperties();
        }
    }
}