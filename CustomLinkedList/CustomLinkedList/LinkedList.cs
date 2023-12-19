namespace CustomLinkedList
{
    public class LinkedList<T>
    {
        //Properties
        public Node<T> First { get; private set; }
        public Node<T> Last { get; private set; } //Last maybe not necessary

        //Count the members in the LinkedList
        public int Count { get; private set; }

        //Constructer. Not really needed, just a reminder that we will start from 0
        public LinkedList()
        {
            this.First = null;
            this.Last = null;
        }

        //Add First
        public void AddFirst(Node<T> newNode)
        {
            if (this.First == null)
            {
                //LinkedList is empty
                //insert the new node on point the head and tail to the node
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                newNode.Next = this.First;
                this.First = newNode;
            }
            Count++;
        }

        //Add Last
        public void AddLast(Node<T> newNode)
        {
            if (this.First == null)
            {
                //LinkedList is empty
                //insert the new node on point the head and tail to the node
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                this.Last.Next = newNode;
                this.Last = newNode;
            }
            Count++;
        }

        //Add After
        public void AddAfter(Node<T> newNode, Node<T> existingNode)
        {
            //if we adding after the last node, then
            //you need to repoint Last Pointer
            if (this.Last == existingNode)
            {
                this.Last.Next = newNode;
                this.Last = newNode;
            }
            newNode.Next = existingNode.Next;
            existingNode.Next = newNode;
            Count++;
        }

        //Find Node
        public Node<T> Find(T target)
        {
            Node<T> currentNode = this.First;
            while (currentNode != null && !currentNode.Data.Equals(target))
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }


    }
}
