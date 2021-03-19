using System;

namespace problem1
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            head = tail = null;
        }

        public void Append(T t)
        {
            Node<T> n = new Node<T>(t);
            if(tail==null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> p = head;
            while(p!=null)
            {
                action(p.Data);
                p = p.Next;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> a = new GenericList<int>();

            a.Append(0);
            a.Append(5);
            a.Append(3);
            a.Append(2);
            a.Append(9);
            a.Append(8);

            a.ForEach(i =>{ Console.WriteLine(i); });

            int max= -2147483648;
            a.ForEach(i => { max = i > max ? i : max; });
            Console.WriteLine(max);

            int min = 2147483647;
            a.ForEach(i => { min = i < min ? i : min; });
            Console.WriteLine(min);

            int sum = 0;
            a.ForEach(i => { sum += i; });
            Console.WriteLine(sum);

        }
    }
}
