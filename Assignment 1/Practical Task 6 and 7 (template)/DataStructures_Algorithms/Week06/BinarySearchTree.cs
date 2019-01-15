using System;
using System.Collections.Generic;
using DataStructures_Algorithms.Week08;

namespace DataStructures_Algorithms.Week06
{
    public class BinarySearchTree<T>
    {
        private int _MinKey = int.MaxValue;
        private int _MaxKey = int.MinValue;

        private BSTNode<T> Root { get; set; }
        public int Count { get; set; }
        public int MinKey { get { return _MinKey; } set { _MinKey = value; } }
        public int MaxKey { get { return _MaxKey; } set { _MaxKey = value; }}

        public void Add(int Key, T Value)
        {
            if (Root == null) { Root = new BSTNode<T>(Key, Value, null); }
            else Add(Key, Value, Root);
            MinKey = Math.Min(MinKey, Key);
            MaxKey = Math.Max(MaxKey, Key);
            Count++;
        }

        private void Add(int key, T value, BSTNode<T> node)
        {
            if (key < node.Key) 
            {
                if (node.LeftChild == null) { node.LeftChild = new BSTNode<T>(key, value, node);}
                else { Add(key, value, node.LeftChild);}
            }
            else if (key > node.Key)
            {
                if (node.Rightchild == null) { node.Rightchild = new BSTNode<T>(key, value, node);}
                else { Add(key, value, node.Rightchild);}
            }
        }

        public void Clear()
        {
            Root = null;
            Count = 0;
            MinKey = int.MaxValue;
            MaxKey = int.MinValue;
        }

        public T Find(int key)
        {
            if (Find(Root, key).Value == null) { return default(T); }
            else { return Find(Root, key).Value; }

        }

        private BSTNode<T> Find(BSTNode<T> nextNode, int key)
        {
            if (nextNode.Key == key) { return nextNode; }
            else if (nextNode.Key > key) { return Find(nextNode.LeftChild, key); }
            else{ return Find(nextNode.Rightchild, key); }


        }

        public bool Contains(int key)
        {
            return Contains(Root, key);
        }

        private bool Contains(BSTNode<T> root, int key)
        {
            if (root == null) return false;
            if (root.Key == key)  return true;
            if (root.Key > key) return Contains(root.LeftChild, key);
            else { return Contains(root.Rightchild, key); }
        }

        public T[] Traverse(TraversalMode mode)
        {
            T[] myArray = new T[]{};

            List<T> myList = new List<T>();

            if (mode == TraversalMode.PRE)
            {
                void Preorder(BSTNode<T> node)
                {
                    node = Root;

                    if (node == null) { return; }

                    myList.Add(node.Value);

                    Preorder(node.LeftChild);

                    Preorder(node.Rightchild);

                }

                myArray = myList.ToArray();
                return myArray;
            }

            if(mode == TraversalMode.POST)
            {
                void Postorder(BSTNode<T> node)
                {
                    node = Root;
                    if (node == null)
                        return;
                    
                    Postorder(node.LeftChild);

                   
                    Postorder(node.Rightchild);

                  
                    myList.Add(node.Value);
                }

                myArray = myList.ToArray();
                return myArray;
            }

            if(mode == TraversalMode.IN)
            {
                void Inorder(BSTNode<T> node)
                {
                    node = Root;
                    if (node == null)
                        return;

                    Inorder(node.LeftChild);

                    myList.Add(node.Value);

                    Inorder(node.Rightchild);
                }
                myArray = myList.ToArray();
                return myArray;
            }
            return myArray;
        }    



        private class BSTNode<TYPE>
        {
            
            public TYPE Value { get; set; }

            public int Key { get; set; }

            public BSTNode<TYPE> LeftChild { get; set; }

            public BSTNode<TYPE> Rightchild { get; set; }

            public BSTNode<TYPE> Parent { get; set; }


            public BSTNode(int Key, TYPE Value, BSTNode<TYPE> Parent)
            {
                this.Key = Key;
                this.Value = Value;
                this.Parent = Parent;
            }

			public override string ToString()
			{
                System.Text.StringBuilder s = new System.Text.StringBuilder();
                s.Append(Parent == null ? "x" : Parent.Value.ToString());
                s.Append(Rightchild == null ? "x" : Rightchild.Value.ToString());
                s.Append(LeftChild == null ? "x" : LeftChild.Value.ToString());
                return s.ToString();

			}
		}
    }
}