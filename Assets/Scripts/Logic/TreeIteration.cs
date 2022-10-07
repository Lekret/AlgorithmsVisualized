using System;
using System.Collections.Generic;

namespace Logic
{
    public interface ITreeNode<out T>
    {
        T Left { get; }
        T Right { get; }
    }
    
    public static class TreeIteration<T> where T : ITreeNode<T>
    {
        public static void RecPreOrder(T current, List<T> result)
        {
            if (current == null) return;
            result.Add(current);
            RecPreOrder(current.Left, result);
            RecPreOrder(current.Right, result);
        }

        public static void RecInOrder(T current, List<T> result)
        {
            if (current == null) return;
            RecInOrder(current.Left, result);
            result.Add(current);
            RecInOrder(current.Right, result);
        }
        
        public static void RecPostOrder(T current, List<T> result)
        {
            if (current == null) return;
            RecPostOrder(current.Left, result);
            RecPostOrder(current.Right, result);
            result.Add(current);
        }

        public static void PreOrder(T current, List<T> result)
        {
            var stack = new Stack<T>();
            while (current != null)
            {
                result.Add(current);
                if (current.Right != null)
                    stack.Push(current.Right);
                if (current.Left != null)
                    stack.Push(current.Left);
                stack.TryPop(out current);
            }
        }

        public static void InOrder(T current, List<T> result)
        {
            var stack = new Stack<T>();
            while (true)
            {
                if (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }
                else if (stack.TryPop(out current))
                {
                    result.Add(current);
                    current = current.Right;
                }
                else
                {
                    break;
                }
            }
        }

        public static void PostOrder(T current, List<T> result)
        {
            var firstStack = new Stack<T>();
            var secondStack = new Stack<T>();
            firstStack.Push(current);
            while (firstStack.TryPop(out var popped))
            {
                secondStack.Push(popped);
                if (popped.Left != null)
                    firstStack.Push(popped.Left);
                if (popped.Right != null)
                    firstStack.Push(popped.Right);
            }

            while (secondStack.TryPop(out var popped))
            {
                result.Add(popped);
            }
        }

        public static void Traverse(T current, List<T> result)
        {
            var queue = new Queue<T>();
            while (current != null)
            {
                result.Add(current);
                if (current.Left != null)
                    queue.Enqueue(current.Left);
                if (current.Right != null)
                    queue.Enqueue(current.Right);
                queue.TryDequeue(out current);
            }
        }
    }
}