using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class QueueP
    {
        Node head = null;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            {
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    Node nodeOne = head;
                    while (nodeOne.next != null)
                    {
                        nodeOne = nodeOne.next;
                    }
                    nodeOne.next = node;
                }
            }

        }
        public void Display()
        {
            Node nodeOne = this.head;
            while(nodeOne != null)
            {
                Console.WriteLine("data : " +nodeOne.data);
                nodeOne = nodeOne.next;
            }
        }
    }
}
