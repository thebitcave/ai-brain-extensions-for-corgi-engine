using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeEditorAttribute(typeof(AIActionJumpNode))]
    public class AIActionJumpNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _numberOfJumps;

        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _numberOfJumps = serializedObject.FindProperty("numberOfJumps");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_numberOfJumps);
            serializedObject.ApplyModifiedProperties();
        }
    }
}