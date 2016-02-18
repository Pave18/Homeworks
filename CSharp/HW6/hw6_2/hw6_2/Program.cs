using System;

namespace hw6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            MyStack ms = new MyStack(size);

            ms.Push(5);
            ms.Push(6);
            ms.Push(7);
            ms.Push(8);
            ms.Push(9);

            for (int i = 0, s = size; i < size; ++i)
                Console.WriteLine($"MyStack {--s} = {ms.Pop()}");
        }
    }

    class MyStack
    {
        object[] arr;
        int top = 0;
        int size;

        public MyStack(int size = 5)
        {
            this.size = size;
            arr = new object[this.size];
        }

        public void Push(object value)
        {
            if (top < size)
                arr[top++] = value;
            else
                throw new StackOverflowException("Stack overflow!");
        }

        public object Pop()
        {
            if (top > 0)
            {
                object temp = arr[--top];
                arr[top] = null;
                return temp;
            }
            else
                throw new ArgumentOutOfRangeException("The Stack is empty!");
        }

        public object Peek()
        {
            if (top > 0)
                return arr[top - 1];
            else
                throw new ArgumentOutOfRangeException("The Stack is empty!");
        }
    }
}
