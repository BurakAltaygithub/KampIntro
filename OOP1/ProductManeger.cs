﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManeger
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" eklendi.");


        }

        public void Uptade(Product product) 
        {
            Console.WriteLine(product.ProductName + " güncellendi.");


        }

       

       
    }
}
