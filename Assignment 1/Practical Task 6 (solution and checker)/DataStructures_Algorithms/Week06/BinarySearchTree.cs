using DataStructures_Algorithms.Week08;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week06
{
    public class BinarySearchTree<T>
    {
        private BSTNode<T> Root { get; set; }
        public int Count { get; private set; }
        public int MinKey { get; private set; }
        public int MaxKey { get; private set; }

        public BinarySearchTree()
        {
            MinKey = int.MaxValue;
            MaxKey = int.MinValue;
        }

        public void Add(int Key,T Value)
        {
            if (Root == null)
                Root = new BSTNode<T>(Key, Value, null);
            else
                Add(Root, Key, Value);
            Count++;
            MinKey = Math.Min(MinKey, Key);
            MaxKey = Math.Max(MaxKey, Key);
        }

        public void Clear()
        {
            Count = 0;
            Root = null;
            MinKey = int.MaxValue;
            MaxKey = int.MinValue;
        }

        private void Add(BSTNode<T> node, int Key, T Value)
        {
            if (Key < node.Key)
            {
                if (node.LeftChild == null) node.LeftChild = new BSTNode<T>(Key, Value, node);
                else Add(node.LeftChild, Key, Value);
            }
            else
            {
                if (node.RightChild == null) node.RightChild = new BSTNode<T>(Key, Value, node);
                else Add(node.RightChild, Key, Value);
            }
        }

        public T Find(int Key)
        {
            BSTNode<T> node = Root;
            while (node != null)
            {
                if (node.Key.Equals(Key)) return node.Value;
                if (Key < node.Key) node = node.LeftChild;
                else node = node.RightChild;
            }
            return default(T);
        }

        public bool Contains(int Key)
        {
            BSTNode<T> node = Root;
            while (node != null)
            {
                if (node.Key.Equals(Key)) return true;
                if (Key < node.Key) node = node.LeftChild;
                else node = node.RightChild;
            }
            return false;
        }

        private int Min(BSTNode<T> node)
        {
            if (Root == null) return int.MaxValue;
            if (node.LeftChild == null) return node.Key;
            return Min(node.LeftChild);
        }

        private int Max(BSTNode<T> node)
        {
            if (Root == null) return int.MinValue;
            if (node.RightChild == null) return node.Key;
            return Max(node.RightChild);
        }

        public T[] Traverse(TraversalMode mode)
        {
            List<T> result = new List<T>(Count);
            switch (mode)
            {
                case TraversalMode.PRE:
                    {
                        PreOrder_Traverse(Root, result);
                        break;
                    }
                case TraversalMode.POST:
                    {
                        PostOrder_Traverse(Root, result);
                        break;
                    }
                case TraversalMode.IN:
                    {
                        InOrder_Traverse(Root, result);
                        break;
                    }
            }
            return result.ToArray();
        }

        private void PreOrder_Traverse(BSTNode<T> node, List<T> result)
        {
            if (node == null) return;
            result.Add(node.Value);
            PreOrder_Traverse(node.LeftChild, result);
            PreOrder_Traverse(node.RightChild, result);
        }

        private void InOrder_Traverse(BSTNode<T> node, List<T> result)
        {
            if (node == null) return;
            InOrder_Traverse(node.LeftChild, result);
            result.Add(node.Value);
            InOrder_Traverse(node.RightChild, result);
        }

        private void PostOrder_Traverse(BSTNode<T> node, List<T> result)
        {
            if (node == null) return;
            PostOrder_Traverse(node.LeftChild, result);
            PostOrder_Traverse(node.RightChild, result);
            result.Add(node.Value);
        }

        public bool Remove(int key)
        {
            BSTNode<T> node = FindToDelete(key);
            if (node == null) return false;
            else { Delete(node, key); return true; }

        }

        private BSTNode<T> Delete(BSTNode<T> node, int key)

        {
            int i = 0;
            if (node == null) { return node; }
            if (node.LeftChild != null) i++;
            if (node.RightChild != null) i++;
            switch (i)
            {
                case 0: // no children
                    if (node == Root) { Root = null; return node; }
                    if (Root.LeftChild == node) { Root.LeftChild = null; }
                    else { Root.RightChild = null; return node; }
                    break;

                case 1: // one child
                    if (node.LeftChild == null) { if (node == Root) { node = Root.RightChild; } return node; }
                    if (Root.LeftChild == node) { Root.LeftChild = node.LeftChild; }
                    else { Root.RightChild = node.RightChild; return node; }
                    if (node.RightChild == null) { if (node == Root) { Root = Root.LeftChild; } return node; }
                    else { Root.LeftChild = node.LeftChild; return node; }

                case 2: // two children
                    break;
            }
            return node;
        }

       

        private BSTNode<T> FindToDelete(int Key)
        {
            BSTNode<T> node = Root;
            while (node != null)
            {
                if (node.Key.Equals(Key)) break;
                if (Key < node.Key) node = node.LeftChild;
                else node = node.RightChild;
            }
            return node;
        }
       
        private class BSTNode<TYPE>
        {
            public BSTNode<TYPE> LeftChild { get; set; }
            public BSTNode<TYPE> RightChild { get; set; }
            public BSTNode<TYPE> Parent { get; set; }
            public TYPE Value { get; set; }
            public int Key { get; set; }

            public BSTNode(int Key, TYPE Value, BSTNode<TYPE> Parent)
            {
                this.Value = Value;
                this.Key = Key;
                this.Parent = Parent;
            }

            public override string ToString()
            {
                System.Text.StringBuilder s = new System.Text.StringBuilder();
                s.Append("{");
                if (LeftChild == null)
                {
                    s.Append("x");
                }
                else
                {
                    s.Append("("); s.Append(LeftChild.Key.ToString()); s.Append(","); s.Append(LeftChild.Value.ToString()); s.Append(")");
                }
                s.Append("-("); s.Append(Key.ToString()); s.Append(","); s.Append(Value.ToString()); s.Append(")-");
                if (RightChild == null) s.Append("x");
                else
                {
                    s.Append("("); s.Append(RightChild.Key.ToString()); s.Append(","); s.Append(RightChild.Value.ToString()); s.Append(")");
                }
                s.Append("}");
                return s.ToString();
            }
        }
    }
}
