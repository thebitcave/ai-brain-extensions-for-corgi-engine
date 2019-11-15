using UnityEngine;
using XNodeEditor;

namespace TheBitCave.MMToolsExtensions.AI
{
    [CustomNodeEditor(typeof(AIBrainStateNode))]
    public class AIBrainStateNodeEditor : NodeEditor
    {
        public override void OnHeaderGUI() {
            GUI.color = Color.white;

            var node = target as AIBrainStateNode;
            if (node == null) return;
            
            var graph = node.graph as AIBrainGraph;
            if (graph == null) return;
            
            var title = target.name;
            if (graph.startingNode == node)
            {
                title = ">> " + target.name;
            }
            else
            {
                GUI.color = new Color(.8f, .8f, .8f);
            }
            GUILayout.Label(title, NodeEditorResources.styles.nodeHeader, GUILayout.Height(30));
            
            GUI.color = Color.white;
        }

        public override void OnBodyGUI() {
            base.OnBodyGUI();
            
            var node = target as AIBrainStateNode;
            if (node == null) return;
//            if (AIBrainStateNode.StartingNode == null) AIBrainStateNode.StartingNode = node;

            var graph = node.graph as AIBrainGraph;
            if (graph == null) return;
            
            if (graph.startingNode != node && GUILayout.Button(C.LABEL_SET_AS_STARTING_STATE)) graph.startingNode = node;
        }

    }
}