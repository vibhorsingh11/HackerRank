﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Codes
{
    //class Level_Order_BST
    //{
    //    class Node
    //    {

    //        public Node left, right;
    //        public int data;
    //        public Node(int data)
    //        {
    //            this.data = data;
    //            left = right = null;
    //        }
    //    }
    //    class Solution
    //    {
    //        static void levelOrder(Node root)
    //        {
    //            //Write your code here
    //            Queue<Node> queue = new Queue<Node>();
    //            if (root != null)
    //            {
    //                queue.Enqueue(root);
    //                while (queue.Count != 0)
    //                {
    //                    Node n = queue.Dequeue();
    //                    Console.WriteLine(n.data);

    //                    if (n.left != null)
    //                    {
    //                        queue.Enqueue(n.left);
    //                    }
    //                    if (n.right != null)
    //                    {
    //                        queue.Enqueue(n.right);
    //                    }
    //                }
    //            }

    //        }
    //        static Node insert(Node root, int data)
    //        {
    //            if (root == null)
    //            {
    //                return new Node(data);
    //            }
    //            else
    //            {
    //                Node cur;
    //                if (data <= root.data)
    //                {
    //                    cur = insert(root.left, data);
    //                    root.left = cur;
    //                }
    //                else
    //                {
    //                    cur = insert(root.right, data);
    //                    root.right = cur;
    //                }
    //                return root;
    //            }
    //        }

    //        static void Main(String[] args)
    //        {
    //            Node root = null;
    //            int T = Int32.Parse(Console.ReadLine());
    //            while (T-- > 0)
    //            {
    //                int data = Int32.Parse(Console.ReadLine());
    //                root = insert(root, data);
    //            }
    //            levelOrder(root);
    //            Console.ReadLine();

    //        }
    //    }
    //}
}
