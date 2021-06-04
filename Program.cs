using System;

namespace mylist
{
    class Program
    {
        static void Main(string[] args)
        {
            mylist list = new mylist();
            Console.WriteLine(list.Count);

            Console.WriteLine("adding house");
            list.Add("house");


            Console.WriteLine("adding car");
            list.Add("car");
            list.Getindex(6);

            Console.WriteLine("adding able");
            list.Add("able");

            Console.WriteLine("adding bat");
            list.Add("bat");

            Console.WriteLine("adding cat");
            list.Add("cat");

            list.PrintAll();
            list.RemoveIndex(3);
            list.PrintAll();

             Console.WriteLine(list.Count);
        }
    }
}
