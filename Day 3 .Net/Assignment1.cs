using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{

    public class Product {

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity {  get; set; }
        public string Category {  get; set; }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> plist = new List<Product>();

            

            for (int i = 0; i < 2; i++) {
                Product p1 = new Product();

                Console.WriteLine("enter productid");
                p1.ProductId = int.Parse(Console.ReadLine());
                Console.WriteLine("enter name");
                p1.Name = Console.ReadLine();
                Console.WriteLine("enter UnitPrice");
                p1.UnitPrice = int.Parse(Console.ReadLine());
                Console.WriteLine("enter Quantity");
                p1.Quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("enter Category");
                p1.Category = Console.ReadLine();

                plist.Add(p1);
                
}


            foreach (Product i in plist) {
                Console.WriteLine("{0}, {1}, {2}, {3},{4}",i.Name, i.UnitPrice, i.Quantity,i.Category,i.ProductId);
            }

            

            Console.ReadLine();

        }
    }
}
