using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionChangeWeaponNode))]
    public class AIActionChangeWeaponNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _newWeapon;

        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _newWeapon = serializedObject.FindProperty("newWeapon");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_newWeapon);
            serializedObject.ApplyModifiedProperties();
        }
    }
}