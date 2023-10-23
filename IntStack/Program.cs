using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntStack
{
    internal class Program
    {
        static void Test1()
        {
            ArrayStack s = new ArrayStack(100);
            int choice;
            int x;
            bool init = false;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Khoi tao danh sach\n2. Them vao stack\n3. Lay ra tu dinh stack\n4. Xem gia tri tren dinh stack\n5. Thoat\nBan chon: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        init = true;
                        Console.WriteLine("Khoi tao stack thanh cong");
                        break;
                    case 2:
                        if (init)
                        {
                            Console.Write("Nhap gia tri x de them: ");
                            x = int.Parse(Console.ReadLine());
                            if (s.push(x))
                                Console.WriteLine("Da them thanh cong");
                            else
                                Console.WriteLine("Them khong thanh cong");
                        }
                        else
                            Console.WriteLine("Khoi tao stack");
                        break;
                    case 3:
                        if (init)
                        {
                            if (s.pop(out x))
                                Console.WriteLine("Gia tri tren dinh lay ra duoc la: " + x);
                            else
                                Console.WriteLine("Khong lay ra duoc");
                        }
                        else
                            Console.WriteLine("Khoi tao stack");
                        break;
                    case 4:
                        if (init)
                        {
                            if (s.peek(out x))
                                Console.WriteLine("Gia tri tren dinh stack la: " + x);
                            else
                                Console.WriteLine("Stack rong");
                        }
                        else
                            Console.WriteLine("Khoi tao stack");
                        break;
                    default:
                        Console.WriteLine("Ket thuc");
                        return;
                }
                Console.ReadLine();
            }
            while (true);
        }

        static void Test2()
        {
            ListStack s2 = new ListStack();
            bool init = false;
            int choice;
            int x;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Khoi tao danh sach\n2. Them vao stack\n3. Lay ra tu dinh stack\n4. Xem gia tri tren dinh stack\n5. Thoat\nBan chon: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        init = true;
                        Console.WriteLine("Khoi tao stack thanh cong");
                        break;
                    case 2:
                        if (init)
                        {
                            Console.Write("Nhap gia tri x de them: ");
                            x = int.Parse(Console.ReadLine());
                            if (s2.Push(x))
                                Console.WriteLine("Da them thanh cong");
                            else
                                Console.WriteLine("Them khong thanh cong");
                        }
                        else
                            Console.WriteLine("Khoi tao stack");
                        break;
                    case 3:
                        if (init)
                        {
                            if (s2.Pop(out x))
                                Console.WriteLine("Gia tri tren dinh lay ra duoc la: " + x);
                            else
                                Console.WriteLine("Khong lay ra duoc");
                        }
                        else
                            Console.WriteLine("Khoi tao stack");
                        break;
                    case 4:
                        if (init)
                        {
                            if (s2.Peek(out x))
                                Console.WriteLine("Gia tri tren dinh stack la: " + x);
                            else
                                Console.WriteLine("Stack rong");
                        }
                        else
                            Console.WriteLine("Khoi tao stack");
                        break;
                    default:
                        Console.WriteLine("Ket thuc");
                        return;
                }
                Console.ReadLine();
            }
            while (true);

        }

        static void Main(string[] args)
        {
            //Test1();
            Test2();
        }
    }
}
