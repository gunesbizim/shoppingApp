using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Application
{
    public class Node
    {
        private Product item;
        private Node prev;
        private Node next;
        public Node()
        {
            prev = null;
            next = null;
            item = null;
        }
        public Node(Product newItem)
        {
            setItem(newItem);
            prev = null;
            next = null;
        }
        public Node(Product newItem, Node nextValue)
        {
            setItem(newItem);
            prev = null;
            next = nextValue;
        }
        public Node(Product newItem, Node prevValue, Node nextValue)
        {
            setItem(newItem);
            prev = prevValue;
            next = nextValue;
        }
        public void setItem(Product newItem)
        {
            item = newItem;
        }
        public void setPrev(Node newPrev)
        {
            prev = newPrev;
        }
        public void setNext(Node newNext)
        {
            next = newNext;
        }
        public Product getItem()
        {
            return item;
        }
        public Node getPrev()
        {
            return prev;
        }
        public Node getNext()
        {
            return next;
        }
    }
}
