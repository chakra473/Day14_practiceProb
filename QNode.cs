using System;

namespace QueueProgram
{
    internal class QNode
    {

        public int key;
        public QNode next;

        public QNode(int key)
        {
            this.key = key;
            this.next = null;
        }
    }
    class Queue
    {
        QNode front, rear;

        public Queue()
        {
            this.front = this.rear = null;
        }

        public void enqueue(int key)
        {
            QNode temp = new QNode(key);

            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }
            this.rear.next = temp;
            this.rear = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Queue Problem");
            Console.WriteLine("Adding elements to Queue");
            Queue q = new Queue();
            q.enqueue(56);
            q.enqueue(30);
            q.enqueue(70);
            Console.WriteLine("statrting element is: " + q.front.key);

        }
    }
}