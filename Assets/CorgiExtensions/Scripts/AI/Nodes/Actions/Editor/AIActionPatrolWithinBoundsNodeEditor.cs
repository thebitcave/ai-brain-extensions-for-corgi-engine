using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeEditorAttribute(typeof(AIActionPatrolWithinBoundsNode))]
    public class AIActionPatrolWithinBoundsNodeEditor : AIActionPatrolNodeEditor
    {
        private SerializedProperty _boundsMethod;
        private SerializedProperty _boundsExtentsLeft;
        private SerializedProperty _boundsExtentsRight;

        public override void OnBodyGUI()
        {
            base.OnBodyGUI();

            _boundsMethod = serializedObject.FindProperty("boundsMethod");
            _boundsExtentsLeft = serializedObject.FindProperty("boundsExtentsLeft");
            _boundsExtentsRight = serializedObject.FindProperty("boundsExtentsRight");

            serializedObject.Update();

            EditorGUIUtility.labelWidth = 130;
            NodeEditorGUILayout.PropertyField(_boundsMethod);
            NodeEditorGUILayout.PropertyField(_boundsExtentsLeft);
            NodeEditorGUILayout.PropertyField(_boundsExtentsRight);
            serializedObject.ApplyModifiedProperties();
            
        }

    }
}
