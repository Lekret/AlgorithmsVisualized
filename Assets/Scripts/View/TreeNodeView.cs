using Logic;
using UnityEngine;

namespace View
{
    public class TreeNodeView : MonoBehaviour, ITreeNode<TreeNodeView>
    {
        public MeshRenderer renderer;
        public TreeNodeView left;
        public TreeNodeView right;

        public TreeNodeView Left => left;
        public TreeNodeView Right => right;
        
        private void Awake()
        {
            renderer.material = new Material(renderer.material);
        }

        public void SetHighlighted(bool value)
        {
            renderer.material.color = value ? Color.green : Color.white;
        }
    }
}