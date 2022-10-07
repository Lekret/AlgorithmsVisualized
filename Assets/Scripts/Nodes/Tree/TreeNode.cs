using UnityEngine;

namespace Nodes.Tree
{
    public class TreeNode : MonoBehaviour, ITreeNode<TreeNode>, IHighlightNode
    {
        public MeshRenderer renderer;
        public TreeNode left;
        public TreeNode right;

        public TreeNode Left => left;
        public TreeNode Right => right;
        
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