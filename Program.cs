using System;

namespace mylist
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();
            Console.WriteLine(list.Count());

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
            list.Insert(3, "dog");
            list.PrintAll();

             Console.WriteLine(list.Count());

            foreach(string t in list)
            {
                
            }
        }
    }
}
