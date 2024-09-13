using System;
using System.Collections.Generic;

namespace Domain2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] locations = {"Centennial","Denver","Greeley","Lakewood"};
            
            var searchResult = Array.Find(locations, element => element.StartsWith("L"));
            
            Console.WriteLine(searchResult);
        }
    }  
}