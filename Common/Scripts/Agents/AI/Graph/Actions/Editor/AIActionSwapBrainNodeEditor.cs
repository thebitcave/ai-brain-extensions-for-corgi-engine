using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionSwapBrainNode))]
    public class AIActionSwapBrainNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _newAIBrain;
        
        protected override void SerializeAdditionalProperties()
        {
            _newAIBrain = serializedObject.FindProperty("newAIBrain");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_newAIBrain);
            serializedObject.ApplyModifiedProperties();
        }
    }
}