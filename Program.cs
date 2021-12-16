using System;

namespace ข้อ8Final
{
    class Node { protected Node next = null; }

    class Product : Node
    {

        public Product Next
        {
            get { return next as Product; }
            set { next = value; }
        }

        public string Partproduct;
        public int numofproduct;
        public Product(string partproductvalue, int numofproductvalue)
        {
            Partproduct = partproductvalue;
            numofproduct = numofproductvalue;
        }
    }

    class PartProduct
    {
        private Product root = null;

        public void Push(Product newCard)
        {
            newCard.Next = root;
            root = newCard;
        }

        public Product Pop()
        {
            Product part = root;
            root = root.Next;
            part.Next = null;
            return part;
        }

        public Product Get(int index)
        {
            Product part = root;
            while (index > 0)
            {
                if (part == null)
                {
                    throw new IndexOutOfRangeException();
                }
                part = part.Next;
                index--;
            }
            return part;
        }


    }
    class Program
    {
        static void Main(string[] args)
        { 
            int productnum = int.Parse(Console.ReadLine());
            while(true)
            {
                string inputpart = Console.ReadLine(); 
            }

           
        }

    }
}
