using UnityEditor;
using UnityEngine;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeEditorAttribute(typeof(AIActionPatrolNode))]
    public class AIActionPatrolNodeEditor : NodeEditor
    {
        protected SerializedProperty _label;
        protected SerializedProperty _output;

        protected SerializedProperty _changeDirectionOnWall;
        protected SerializedProperty _avoidFalling;
        protected SerializedProperty _holeDetectionOffset;
        protected SerializedProperty _holeDetectionRaycastLength;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            /*
            _changeDirectionOnWall = serializedObject.FindProperty("changeDirectionOnWall");
            _avoidFalling = serializedObject.FindProperty("avoidFalling");
            _holeDetectionOffset = serializedObject.FindProperty("holeDetectionOffset");
            _holeDetectionRaycastLength = serializedObject.FindProperty("holeDetectionRaycastLength");
*/
/*            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_label);
            NodeEditorGUILayout.PropertyField(_output);
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_changeDirectionOnWall);
            NodeEditorGUILayout.PropertyField(_avoidFalling);
            NodeEditorGUILayout.PropertyField(_holeDetectionOffset);
            NodeEditorGUILayout.PropertyField(_holeDetectionRaycastLength);
            serializedObject.ApplyModifiedProperties();
            */
        }
    }
}