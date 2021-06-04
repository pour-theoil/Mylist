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
        
           Console.WriteLine("adding car");
            list.Add("car");
          
            Console.WriteLine("adding car");
            list.Add("car");
           
            Console.WriteLine("adding car");
            list.Add("car");
            
        }
    }
}
