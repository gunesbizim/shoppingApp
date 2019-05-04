using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Application
{
    public class OrderedDoublyLinkedList
    {
        private Node first;
        private Node last;

        public OrderedDoublyLinkedList()
        {
            first = null;
            last = null;
        }
        public bool isEmpty()
        {
            return (first == null);
        }

        public void insert(Product item)
        {
            if (isEmpty())
            {
                first = last = new Node(item, first);
            }
            else{
                Node newItem = new Node(item);
                Node current = first;
                while (current != null)
                {
                    Console.WriteLine(current.getItem().getName().CompareTo(item.getName()));
                    if (current.getItem().getName().CompareTo(item.getName()) >= 0)
                    {
                        if (current == first)
                        {
                            newItem.setNext(first);
                            first.setPrev(newItem);
                            first = newItem;
                            break;
                        }  
                        else{
                            newItem.setPrev(current.getPrev());
                            current.getPrev().setNext(newItem);
                            newItem.setNext(current);
                            current.setPrev(newItem);
                            break;
                        }
                    }else if (current == last){
                        last.setNext(newItem);
                        newItem.setPrev(last);
                        last = newItem;
                        break;
                    }
                    current = current.getNext();
                }
            }
        }
        public bool remove(Product item)
        {
            if (isEmpty())
            {
                Console.WriteLine("The list is empty!");
                return false;
            }
             else{
                Node current = first;
                while (current != null)
                {
                    if (current.getItem().getName().Equals(item.getName()))
                    {
                        if (current == first)
                        {
                            if (first == last)
                                first = last = null;
                            else
                            {
                                first = current.getNext();
                                first.setPrev(null);
                            }
                            return true;
                        }
                       
                    else if (current == last)
                        {
                            current.getPrev().setNext(null);
                            last = current.getPrev();
                            return true;
                        }
                       
                    else{
                            current.getPrev().setNext(current.getNext());
                            current.getNext().setPrev(current.getPrev());
                            return true;
                        }
                    }
                    current = current.getNext();
                }
                Console.WriteLine(item.getName() + " is not in the list!");
                return false;
            }
        }
        public int size()
        {
            int count = 0;
            Node current = first;
            while (current != null)
            {
                count++;
                current = current.getNext();
            }
            return count;
        }
        public void outputList()
        {
            Node current = first;
            while (current != null)
            {
                current = current.getNext();
            }
        }
        public void outputListBackward()
        {
            Node current = last;
            while (current != null)
            {
                Console.WriteLine(current.getItem().getName());
                current = current.getPrev();
            }
        }
        public Node getFirst()
        {
            return first;
        }
    }
}


