using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }

        public int Topla(int x, int y)
        {
            return x + y;
        }

        public void Topla2(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
