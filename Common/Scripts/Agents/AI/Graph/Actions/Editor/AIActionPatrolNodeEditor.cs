using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionPatrolNode))]
    public class AIActionPatrolNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _changeDirectionOnWall;
        private SerializedProperty _avoidFalling;
        private SerializedProperty _holeDetectionOffset;
        private SerializedProperty _holeDetectionRaycastLength;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();

            if (CollapseNodeOn) return;

            _changeDirectionOnWall = serializedObject.FindProperty("changeDirectionOnWall");
            _avoidFalling = serializedObject.FindProperty("avoidFalling");
            _holeDetectionOffset = serializedObject.FindProperty("holeDetectionOffset");
            _holeDetectionRaycastLength = serializedObject.FindProperty("holeDetectionRaycastLength");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 180;
            NodeEditorGUILayout.PropertyField(_changeDirectionOnWall);
            NodeEditorGUILayout.PropertyField(_avoidFalling);
            NodeEditorGUILayout.PropertyField(_holeDetectionOffset);
            NodeEditorGUILayout.PropertyField(_holeDetectionRaycastLength);
            serializedObject.ApplyModifiedProperties();
            
        }
    }
}