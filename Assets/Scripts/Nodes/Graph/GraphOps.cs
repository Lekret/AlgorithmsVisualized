using System.Collections.Generic;

namespace Nodes.Graph
{
    public static class GraphOps
    {
        public static void Traverse<T>(T current, HashSet<T> result) where T : INode<T>
        {
            var queue = new Queue<T>();
            while (current != null)
            {
                result.Add(current);
                foreach (var n in current.Nodes)
                {
                    queue.Enqueue(n);
                }
                queue.TryDequeue(out current);
            }
        }
    }
}