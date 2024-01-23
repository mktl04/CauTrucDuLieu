using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NganXep
{
    class Stack
    {//
        private int[] data;
        private int top;
        public Stack()
        {
            data = new int[100];
            top = -1;
        }
        public Stack(int size)
        {
            data = new int[size];
            top = -1;
        }
        //dinh nghia phuong thuc kiem tra rong
        public bool isEmpty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }
        public bool isFull()
        {
            bool kQ = false;
            if (top == data.Length - 1)
                kQ = true;
            return kQ;
        }
        public void Push(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Stack full!");
            }
            else
            {
                data[++top] = x;
            }
        }
        public int Pop()
        {
            int kq = 0;
            if (isEmpty())
            {
                Console.WriteLine("Stack full!");
            }
            else
            {
                kq = data[top--];
            }
            return kq;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap co so he 10: ");
            n = int.Parse(Console.ReadLine());
            Stack s = new Stack();
            {
                s.Push(n % 2);
                n = n / 2;
            }
            Console.Write("Bieu dien he 2:");
            while (!s.isEmpty())
            {
                Console.Write(s.Pop());
            }
            Console.ReadLine();
        }
    }
}
