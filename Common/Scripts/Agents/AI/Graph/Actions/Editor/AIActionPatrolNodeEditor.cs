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
        
        private SerializedProperty _useCustomLayermask;
        private SerializedProperty _obstaclesLayermask;
        private SerializedProperty _obstaclesDetectionRaycastLength;
        private SerializedProperty _obstaclesDetectionRaycastOrigin;
        
        private SerializedProperty _resetPositionOnDeath;

        protected override void SerializeAdditionalProperties()
        {
            _changeDirectionOnWall = serializedObject.FindProperty("changeDirectionOnWall");
            _avoidFalling = serializedObject.FindProperty("avoidFalling");
            _holeDetectionOffset = serializedObject.FindProperty("holeDetectionOffset");
            _holeDetectionRaycastLength = serializedObject.FindProperty("holeDetectionRaycastLength");

            _useCustomLayermask = serializedObject.FindProperty("useCustomLayermask");
            _obstaclesLayermask = serializedObject.FindProperty("obstaclesLayermask");
            _obstaclesDetectionRaycastLength = serializedObject.FindProperty("obstaclesDetectionRaycastLength");
            _obstaclesDetectionRaycastOrigin = serializedObject.FindProperty("obstaclesDetectionRaycastOrigin");
            
            _resetPositionOnDeath = serializedObject.FindProperty("resetPositionOnDeath");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 180;
            NodeEditorGUILayout.PropertyField(_changeDirectionOnWall);
            NodeEditorGUILayout.PropertyField(_avoidFalling);
            NodeEditorGUILayout.PropertyField(_holeDetectionOffset);
            NodeEditorGUILayout.PropertyField(_holeDetectionRaycastLength);
            NodeEditorGUILayout.PropertyField(_useCustomLayermask);

            if (_useCustomLayermask.boolValue)
            {
                EditorGUIUtility.labelWidth = 130;
                NodeEditorGUILayout.PropertyField(_obstaclesLayermask);
                EditorGUIUtility.labelWidth = 170;
                NodeEditorGUILayout.PropertyField(_obstaclesDetectionRaycastLength);
                NodeEditorGUILayout.PropertyField(_obstaclesDetectionRaycastOrigin);
            }
            
            NodeEditorGUILayout.PropertyField(_resetPositionOnDeath);

            serializedObject.ApplyModifiedProperties();
            
        }
    }
}