using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17._2
{
    public class Product
    {
        int pid;
        string pname;
        double pprice;
        public Product()
        {
            Console.WriteLine("Default Constructor");
            pid = 0;
            pname = "no name";
            pprice = 0;
        }

        public virtual void Set()
        {
            Console.WriteLine("Enter Product Id");
            pid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            pname = Console.ReadLine();
            Console.WriteLine("Enter Product Price");
            pprice = double.Parse(Console.ReadLine());
        }

        public virtual void Show()
        {
            Console.WriteLine("ID: " + pid);
            Console.WriteLine("Name: " + pname);
            Console.WriteLine("Price: " + pprice);
        }
    }
}
