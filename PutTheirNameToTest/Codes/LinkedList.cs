﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutTheirNameToTest.Codes
{
    class LinkedList
    {
    }
    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }
    class Solution
    {
        public static Node insert(Node head, int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                Node newNode = new Node(data);
                n.next = newNode;
                newNode.next = null;
            }
            return head;
        }
        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        static void Main(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
    }
}
