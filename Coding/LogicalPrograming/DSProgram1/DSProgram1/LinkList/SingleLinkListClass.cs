using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSProgram1.LinkList
{

    public class Node
    {
        public object data { get; set; }
        public Node Next { get; set; }
        public Node(object obj)
        {
            data = obj;
        }
    }
    internal class SingleLinkListClass
    {
         Node Head { get; set; }

         void AddAtFirst(Node node)
        {
            node.Next = Head;
            Head = node;
        }
         void AddAtLast(Node node)
        {
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Node Current = Head;
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = node;
            }

        }
         void AddAtPositon(Node node, int positon)
        {

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Node Current = Head;
                for (int i = 0; i < positon - 1; i++)
                {
                    Current = Current.Next;
                }
                node.Next = Current.Next;
                Current.Next = node;
            }

        }

         void ReadLinkList()
        {
            Node Current = Head;
            while (Current != null)
            {
                Console.WriteLine("List :" + Current.data);

                Current = Current.Next;

            }
            Console.ReadKey();

        }

        public void LinkListMain()
        {
            var linklist = new SingleLinkListClass();

            linklist.AddAtFirst(new Node(1));
            linklist.AddAtFirst(new Node(2));
            linklist.AddAtFirst(new Node(3));
            linklist.AddAtFirst(new Node(4));

            linklist.AddAtLast(new Node(11));
            linklist.AddAtLast(new Node(22));
            linklist.AddAtLast(new Node(33));
            linklist.AddAtLast(new Node(44));

            linklist.AddAtPositon(new Node("Postion At 777"), 7);
            linklist.ReadLinkList();


        }

    }
}
