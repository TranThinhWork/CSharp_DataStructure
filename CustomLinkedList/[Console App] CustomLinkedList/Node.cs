using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class Node<T>
    {
        //Data
        public T Data { get; set; }

        //Link (point to the next item)
        public Node<T> Next { get; internal set; }

        //Constructer
        public Node(T data)
        {
            this.Data = data;
        }
    }
}
