using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachLienKetDon
{
    class Node
    {
        private int info;
        private Node next;
        public Node (int x)
        {
            info = x;
            next = null;
        }
        public int Info
        {
            set { this.info = value; }
            get { return info; }
        }
        public Node Next
        {
            set { this.next = value; }
            get { return next; }
        }
    }
    class SingleLinkList
    {
        private Node Head;
        public SingleLinkList()
        { Head = null; }

        public void AddHead(int x)
        {
            Node p = new Node(x);
            p.Next = Head;
            Head = p;
        }
        public void DeleteHead()
        { if (Head != null)
            {
                Node p = Head;
                Head = Head.Next;
                p.Next = null;
            }
        }
        public void DeleteLast()
        {
            if (Head != null)
            {
                Node p = Head;
                Node q = null;
                while (p.Next != null)
                {
                    q = p;
                    p = p.Next;
                }
                q.Next = null;
            }
        }

        public void AddLast(int x)
        {
            Node p = new Node(x);
            if ( Head == null)
            {
                Head = p;
            }    
            else
            {
                Node q = Head;
                while (q.Next != null) { q = q.Next; }
                q.Next = p;
            }
        }
        public void ProcessList()
        {
            Node p = Head;
            while (p != null)
            {
                Console.Write($"{p.Info}  ");
                p = p.Next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SingleLinkList l = new SingleLinkList();
            l.AddHead(9);
            l.AddHead(7);
            l.AddHead(5);
            l.AddLast(3);
            NhapDanhSach(l);
            Console.WriteLine("Danh sách liên kết: ");
            l.ProcessList();
            l.DeleteHead();
            Console.WriteLine("\n Danh sách liên kết sau khi bị xoá nút đầu:");
            l.ProcessList();
            l.DeleteLast();
            Console.WriteLine("\n Danh sách liên kết sau khi bị xoá nút cuối:");
            l.ProcessList();
            Console.ReadLine();
        }
        static void NhapDanhSach(SingleLinkList l)
        {
            string chon ="y";
            int x;
            while (chon != "n")
            {
                Console.WriteLine("Nhập giá trị nút: ");
                x = int.Parse(Console.ReadLine());
                l.AddLast(x);
                Console.Write("Tiếp tục (y/n)?");
                chon = Console.ReadLine();
            }
        }
    }
}
