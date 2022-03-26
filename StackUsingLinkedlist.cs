using System;

namespace StackProblem
{
    public class StackUsingLinkedlist
    {
        private class Node
        {
            public int data;
            public Node link;
        }
        Node top;
        public StackUsingLinkedlist()
        {
            this.top = null;
        }

        public void Push(int x)
        {
            Node temp = new Node();

            temp.data = x;
            temp.link = top;
            top = temp;
        }

        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Nothing in the Stack");
                return;
            }
            else
            {
                Console.WriteLine("The Elements of Stack Is:");
                Node temp = top;
                while (temp != null)
                {
                    Console.Write("{0} ", temp.data);
                    temp = temp.link;
                }
            }
        }

        public void pop()
        {
            if (top == null)
            {
                Console.Write("Nothing in the stack");
                return;
            }
            top = (top).link;
        }

        public bool isEmpty()
        {
            return top == null;
        }
        public int peek()
        {
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }

        public static void Main(String[] args)
        {
            StackUsingLinkedlist obj = new StackUsingLinkedlist();

            obj.Push(56);
            obj.Push(30);
            obj.Push(70);

            obj.Display();

            Console.WriteLine("\nPerforming Pop operation");
            Console.WriteLine("Top peek item in stack is: {0}", obj.peek());
            obj.pop();
            Console.WriteLine("Top peek item in stack is: {0}", obj.peek());
            obj.pop();
            Console.WriteLine("Top peek item in stack is: {0}", obj.peek());
            obj.pop();
            obj.peek();
        }
    }
}