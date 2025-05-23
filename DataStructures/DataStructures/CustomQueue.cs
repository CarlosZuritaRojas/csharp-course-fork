using System.Xml.Linq;

namespace DataStructures
{
    // FIFO
    public class CustomQueue<T>
    {
        private class Node
        {
            public T Value { get; set; }
            public Node? Next { get; set; } = null!;

            public Node(T value)
            {
                Value = value;
            }
        }

        private Node? _head;
        private Node? _tail;
        // TODO: Implement queue (you can modify the implementation, not the names of the methods) DONE
        private int _count = 0;

        public int Count => _count;

        public void Enqueue(T item)
        {
            // Add items
            if (_head == null)
            {
                _head = new Node(item);
                _tail = _head;
            }
            else
            {
                _tail!.Next = new Node(item);
                _tail = _tail.Next;
            }
            _count++;
        }

        public T Dequeue()
        {
            // remove items
            if (_head == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            
            var result = _head;
            _head = _head.Next;
            _count--;

            return result.Value;    
        }

        public T Peek()
        {
            if (_head == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return _head.Value;
        }

        public bool IsEmpty() => true;

        public T[] ToArray()
        {
            T[] array = new T[_count];
            var index = 0;
            while (_head != null)
            {
                array[index++] = this.Dequeue();
            }

            return array;
        }
    }
}
