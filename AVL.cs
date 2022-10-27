using System.Drawing;
using System.Collections.Generic;

namespace AVL1
{
    using System;
    using System.Collections;
    using System.Windows.Forms;
    using System.Xml.Linq;
    using System.Collections.Generic;
    using System.Linq;

    [Serializable]
    public class Node
    {
        public Position Position;
        public int data;
        public int height;
        public Node right;
        public Node left;
        public Node father;

        public Node(int data=0)
        {
            this.data = data;
            this.height = 0;
            Position = new Position();
        }
       virtual public string toString()
        {
           return data.ToString();
        }
        protected void GetAllNodes(AVL root, ICollection<AVL> collection)
        {
            if (root == null)
            {
                return;
            }
            collection.Add(root);
            GetAllNodes((AVL)root.left, collection);
            GetAllNodes((AVL)root.right, collection);
        }

    }
    [Serializable]
    public class Binary_Tree : Node
    {
        public Binary_Tree(int data=0) : base(data)
        {

        }
        public AVL Inorder(AVL tmp, List<int> L)
        {
            
            if (tmp == null) return null;
            else
            {
                return Inorder((AVL)tmp.left, L);
                L.Add(tmp.data);
                return Inorder((AVL)tmp.right, L);
            }

        }

        public Binary_Tree Insert(AVL root,int x) 
        {
            
             

            if (root.data == 0)
            {
                root.data = x;
                return root;
            }


            if (x < (int)root.data)
            {

                if (root.left == null)
                    root.left = (AVL)new AVL();
                root.left = Insert((AVL)root.left, x);
                AVL par = (AVL)root.left;
                par.father = root;

            }
            else if (x > (int)root.data)
            {
                if (root.right == null)
                    root.right = (AVL)new AVL();
                root.right = Insert((AVL)root.right, x);
                AVL par = (AVL)root.right;
                par.father = root;
            }
            root.Fix_Height(root);

            return root;

            

        }
        public bool Find(AVL root,int k) 
        {
            AVL tmp = root;
            
            while(tmp!=null)
            {
                if (tmp.data == k) 
                    return true;
                else if (tmp.data > k)
                    tmp = (AVL)tmp.left;
                else
                    tmp = (AVL)tmp.right;
            }
            return false;

        }
        public int Fix_Height(AVL x)
        {

            if (x == null)
            {
                return -1;
            }

            int lefth = Fix_Height((AVL)x.left);
            int righth = Fix_Height((AVL)x.right);
            x.height = Math.Max(lefth, righth) + 1;
            x.BF = lefth - righth;
            return (int)x.height;
        }
        public Binary_Tree Delete(AVL root,int x)
        {
            if (root == null)
                return root;

            if (x < root.data)
                root.left = Delete((AVL)root.left, x);
            else if (x > root.data)
                root.right = Delete((AVL)root.right, x);

            else
            {
                if (root.left == null)
                    return (AVL)root.right;
                else if (root.right == null)
                    return (AVL)root.left;
                root.data = minValue((AVL)root.right);
                root.right = Delete((AVL)root.right, root.data);
            }
            return root;
        }

        public int minValue(AVL root)
        {
            int minv = root.data;
            while (root.left != null)
            {
                AVL tmp=(AVL)root.left;
                minv = tmp.data;
                root = (AVL)root.left;
            }
            return minv;
        }

    }
    [Serializable]
    public class AVL : Binary_Tree
    {
    
        public int BF;
        
        
        
        public AVL(int data = 0) : base(data)
        {
            this.BF = 0;
        }
       
        public virtual void storeBSTNodes(AVL root, List<AVL> nodes)
        {
            // Base case
            if (root == null)
            {
                return;
            }

            // Store nodes in Inorder (which is sorted
            // order for BST)
            storeBSTNodes((AVL)root.left, nodes);
            nodes.Add(root);
            storeBSTNodes((AVL)root.right, nodes);
        }

        /* Recursive function to construct binary tree */
        public virtual AVL buildTreeUtil(List<AVL> nodes, int start, int end)
        {
            // base case
            if (start > end)
            {
                return null;
            }

            /* Get the middle element and make it root */
            int mid = (start + end) / 2;
            AVL node = nodes[mid];

            /* Using index in Inorder traversal, construct
               left and right subtress */
            node.left = buildTreeUtil(nodes, start, mid - 1);
            node.right = buildTreeUtil(nodes, mid + 1, end);
            Fix_Height(node);
            return node;
        }

        // This functions converts an unbalanced BST to
        // a balanced BST
        public virtual AVL buildTree(AVL root)
        {
            // Store nodes of given BST in sorted order
            List<AVL> nodes = new List<AVL>();
            storeBSTNodes(root, nodes);

            // Constructs BST from nodes[]
            int n = nodes.Count;
            return buildTreeUtil(nodes, 0, n - 1);
        }

        // public int Fix_Balance_Factor(AVL root,int key)
        // {
        //     //if (root == null)
        //     //    return 0;
        //     //int left = Fix_Balance_Factor((AVL)root.left,key);
        //     //int right = Fix_Balance_Factor((AVL)root.right,key);
        //     //root.BF =(left - right);
        //     //return 1+Math.Max(left, right);
        //     if (root == null)
        //         return 0;

        //     return Fix_Height((AVL)root.left) - Fix_Height((AVL)root.right);


        // }
        //public AVL Rotation(AVL root,int key)
        // {
        //     int balance = Fix_Balance_Factor(root, key);
        //         //left left
        //     if (root.BF > 1 && key < root.left.data)
        //         return rightRotate((AVL)root);
        //     if (balance < -1 && key > root.right.data)
        //         return leftRotate(root);
        //     if (balance > 1 && key > root.left.data)
        //     {
        //         root.left = leftRotate((AVL)root.left);
        //         return rightRotate(root);
        //     }
        //     if (balance < -1 && key < root.right.data)
        //     {
        //         root.right = rightRotate((AVL)root.right);
        //         return leftRotate(root);
        //     }
        //     return root;

        // }
        // AVL rightRotate(AVL y)
        // {
        //     AVL x = (AVL)y.left;
        //     AVL T2 = (AVL)x.right;
        //     // Perform rotation
        //     x.right = y;
        //     y.left = T2;
        //     // Update heights
        //     //y.height = Math.Max(Fix_Height((AVL)y.left),
        //     //            Fix_Height((AVL)y.right)) + 1;
        //     //x.height = Math.Max(Fix_Height((AVL)x.left),
        //     //            Fix_Height((AVL)x.right)) + 1;
        //     Fix_Height(x);
        //     return x;
        // }
        // AVL leftRotate(AVL x)
        // {
        //     AVL y = (AVL)x.right;
        //     AVL T2 = (AVL)y.left;
        //     // Perform rotation
        //     y.left = x;
        //     x.right = T2;
        //     // Update heights
        //     Fix_Height(y);
        //     // Return new root
        //     return y;
        // }

    }
    [Serializable]
    public class Dictionary : Node
    {
        public List<AVL> nodeCollection;

        public Dictionary(int data = 0) : base(data)
        {
            nodeCollection = new List<AVL>();
        }

        public void GetAllNodes(AVL root, ICollection <AVL> collection)
        {
            if (root == null)
            {
                return;
            }            
            collection.Add(root);
            GetAllNodes((AVL)root.left, collection);
            GetAllNodes((AVL)root.right, collection);
        }
    }

    public class TreeConfiguration
    {
        public TreeConfiguration(int circleDiameter=45, int arrowAnchorSize=5)
        {
            CircleDiameter = circleDiameter;
            ArrowAnchorSize = arrowAnchorSize;
        }

        public int CircleDiameter { get; private set; }

        public int ArrowAnchorSize { get; private set; }
    }
    [Serializable]
    public class Position
    {
        public Position()
        {
            this.Y = 0;
            this.X = 0;
        }
        public int X { get; set; }

        public int Y { get; set; }
    }
    [Serializable]
    public class FullTree:Binary_Tree
    {
        public bool isFullTree(Node node)
        {
            // if empty tree
            if (node == null)
            {
                return true;
            }
            if (node.left == null && node.right == null)
            {
                return true;
            }

            if ((node.left != null) && (node.right != null))
            {
                return (isFullTree(node.left) &&
                        isFullTree(node.right));
            }
            return false;
        }
    }

}

