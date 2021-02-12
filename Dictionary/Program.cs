using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> _arrays = new MyDictionary<int, string>();
            _arrays.Add(1, "Laptop");
            _arrays.Add(2, "Telefon");
            _arrays.Add(3, "Yazıcı");
            _arrays.Add(4, "Kamera");

            Console.WriteLine("Count :{0} ", _arrays.Count);
            _arrays.List();
           
            Console.ReadLine();

        } 
    }
}
