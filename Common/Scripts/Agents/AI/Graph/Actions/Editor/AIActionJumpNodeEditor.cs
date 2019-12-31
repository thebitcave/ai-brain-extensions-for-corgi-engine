using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionJumpNode))]
    public class AIActionJumpNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _numberOfJumps;

        protected override void SerializeAdditionalProperties()
        {
            _numberOfJumps = serializedObject.FindProperty("numberOfJumps");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_numberOfJumps);
            serializedObject.ApplyModifiedProperties();
        }
    }
}