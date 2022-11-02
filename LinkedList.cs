using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_linkedlist
{
    internal class LinkedList
    {
        private Node Head;

        //https://stackoverflow.com/questions/3823848/creating-a-very-simple-linked-list#3823909
        public void Add(string data)
        {
            if (Head == null)
            {
                Head = new Node(data);
                Head.next = null;

            }
            else
            {

                Node Add = new Node(data);
                Node current = Head;
                //Node Temp = Head;

                while (current.next != null)
                {

                    current = current.next;
                }

                current.next = Add;

                //this would be the last iteration of my failed attempt at sorting I tried in the whili loop
                //out of the while loop and in it's own loop.
                //if (current.next.Data.CompareTo(Temp.Data) < 0)
                //{
                //    current.next = current;
                //    Temp = current.next;
                //    current = Temp;

                //}


            }
        }



        //https://stackoverflow.com/questions/1432818/remove-node-from-single-linked-list
        public void delete(string delete)
        {
            Console.WriteLine("Deleting " + delete);
            Node temp = Head;
            Node current = Head;
            Node previous = null;

            if (temp == null)
            {
                Console.WriteLine("Never mind. Can't delete " + delete + " if this list is empty.");
                return;
            }

            while (temp != null)
            {
                current = temp;

                if (temp.Data != delete)
                {
                    Console.WriteLine("Name not found. Did you type it correctly?");
                    return;
                }
                if (temp.Data == delete)
                {
                    if (previous != null)
                    {
                        previous.next = current.next;
                    }
                    else
                    {
                        Head = Head.next;
                    }
                    break;
                }
                previous = current;
                temp = temp.next;
            }

            
        }

        public void Print()
        {
            Node current = Head;
            if (current == null)
            {
                Console.WriteLine("Nothing to print");
                return;
            }
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.next;
            }
        }

        public bool search(string found)
        {
            Node current = Head;
            if (current == null)
            {
                Console.WriteLine("The list is empty.");
                return false;
            }
            while (current != null)
            {

                if (found.Contains(current.Data))
                {
                    Console.WriteLine(found + " was found!");
                    return true;
                }

                current = current.next;
            }

            return false;

        }
    }
}
