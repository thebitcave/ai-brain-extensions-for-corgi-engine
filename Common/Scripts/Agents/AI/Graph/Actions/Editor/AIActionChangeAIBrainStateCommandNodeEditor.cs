using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionChangeAIBrainStateCommandNode))]
    public class AIActionChangeAIBrainStateCommandNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _channelName;
        private SerializedProperty _stateName;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            EditorGUIUtility.labelWidth = 100;
            _channelName = serializedObject.FindProperty("channelName");
            _stateName = serializedObject.FindProperty("stateName");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_channelName);
            NodeEditorGUILayout.PropertyField(_stateName);
            serializedObject.ApplyModifiedProperties();
        }
    }
}