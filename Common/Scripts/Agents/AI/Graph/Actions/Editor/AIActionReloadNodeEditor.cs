using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionReloadNode))]
    public class AIActionReloadNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _onlyReloadOnceInThisSate;

        protected override void SerializeAdditionalProperties()
        {
            _onlyReloadOnceInThisSate = serializedObject.FindProperty("onlyReloadOnceInThisSate");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 200;
            NodeEditorGUILayout.PropertyField(_onlyReloadOnceInThisSate);
            serializedObject.ApplyModifiedProperties();
        }
    }
}