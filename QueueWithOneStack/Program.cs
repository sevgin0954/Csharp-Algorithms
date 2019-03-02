using System.Collections.Generic;

namespace QueueWithOneStack
{
    class Program
    {
        static void Main()
        {
            QueueCustom<int> queueCustom = new QueueCustom<int>();
        }
    }

    class QueueCustom<T>
    {
        private int length = 0;

        private readonly Stack<T> data;

        public QueueCustom()
        {
            data = new Stack<T>();
        }

        public int Length
        {
            get
            {
                return length;
            }
            private set
            {
                length = value;
            }
        }

        public void Enqueue(T element)
        {
            data.Push(element);

            Length++;
        }

        public T Dequeue()
        {
            Length--;

            return GetBottomElement(true);
        }

        public T Peek()
        {
            return GetBottomElement(false);
        }

        private T GetBottomElement(bool shouldRemove)
        {
            if (data.Count == 1)
            {
                if (shouldRemove == false)
                {
                    return data.Peek();
                }
                else
                {
                    return data.Pop();
                }
            }

            T curentElement = data.Pop();

            T bottomElement = GetBottomElement(shouldRemove);

            data.Push(curentElement);

            return bottomElement;
        }
    }
}
