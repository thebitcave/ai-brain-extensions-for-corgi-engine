using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeEditorAttribute(typeof(AIActionPatrolWithinBoundsNode))]
    public class AIActionPatrolWithinBoundsNodeEditor : NodeEditor
    {
        protected SerializedProperty _label;
        protected SerializedProperty _output;

        protected SerializedProperty _boundsMethod;
        protected SerializedProperty _boundsExtentsLeft;
        protected SerializedProperty _boundsExtentsRight;

    }
}
