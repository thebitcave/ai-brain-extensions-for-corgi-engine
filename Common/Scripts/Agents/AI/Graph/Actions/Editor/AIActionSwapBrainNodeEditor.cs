using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionSwapBrainNode))]
    public class AIActionSwapBrainNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _newAIBrain;
        private SerializedProperty _keepTarget;
        
        protected override void SerializeAdditionalProperties()
        {
            _newAIBrain = serializedObject.FindProperty("newAIBrain");
            _newAIBrain = serializedObject.FindProperty("keepTarget");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_newAIBrain);
            NodeEditorGUILayout.PropertyField(_keepTarget);
            serializedObject.ApplyModifiedProperties();
        }
    }
}