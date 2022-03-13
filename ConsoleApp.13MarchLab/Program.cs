using System;
using System.Collections.Generic;

namespace ConsoleApp._13MarchLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic type example
            //Print_any<string>("Elvin");
            #endregion

            #region Custom Class example
            //Info<string> info = new Info<string>();
            //info.Values = new string[0];
            //info.ForSearch();

            //Info<int> info2= new Info<int>();
            //Print_any<string>("Ramin");
            //Print_any<int>(5);
            #endregion

            List<Human> list = new List<Human>();
            // First method
            Human human1 = new Human
            {
                name = "Elvin",
                surname = "Aliyev"
            };
            // Second method
            Human human2 = new Human("Ali", "Shengol");
            // Third method
            Human human3 = new Human();
            human3.name = "Ramin";
            human3.surname = "Safarli";

            list.Add(human1);
            list.Add(human2);
            list.Add(human3);
            list.ForEach(item => { Console.WriteLine(item); });
            Console.WriteLine("********");
            list.Remove(human1);
            list.ForEach(item => { Console.WriteLine(item); });

            int.TryParse(Console.ReadLine(), out int userReqem);
            list.RemoveAt(userReqem - 1);
            list.IndexOf(human2);
        }
        #region
        public static void Print_any<T>(T name)
        {
            Console.WriteLine(name);
        }
        #endregion
    }
    #region Custom Class
    class Info<T>
    {
        public T[] Values;
        public void ForSearch()
        {
            foreach (T item in Values)
            {
                Console.WriteLine(item);
            }
        }
    }
    #endregion

    class Human
    {
        public string name;
        public string surname;
        public Human()
        {

        }
        public Human(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public override string ToString()
        {
            return $"Name: {name} | Surname: {surname}";
        }
    }
}
