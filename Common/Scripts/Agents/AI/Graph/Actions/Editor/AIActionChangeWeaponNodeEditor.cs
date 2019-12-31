using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionChangeWeaponNode))]
    public class AIActionChangeWeaponNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _newWeapon;

        protected override void SerializeAdditionalProperties()
        {
            _newWeapon = serializedObject.FindProperty("newWeapon");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_newWeapon);
            serializedObject.ApplyModifiedProperties();
        }
    }
}