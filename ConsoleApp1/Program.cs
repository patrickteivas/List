using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////ESIMENE LÄHENEMINE
            //var cars = new List<string>();
            //var car1 = "BMW";
            //var car2 = "Lada";
            //var car3 = "Mercedes";
            //var car4 = "Ferrari";
            //var car5 = "Opel";
            //var car6 = "Saab";

            //cars.Add(car1);
            //cars.Add(car2);
            //cars.Add(car3);
            //cars.Add(car4);
            //cars.Add(car5);
            //cars.Add(car6);

            //foreach (var item in cars)
            //{
            //    Console.WriteLine(item);
            //}


            ////TEINE LÄHENEMINE
            //var cars = new List<string> { "BMW", "Lada", "Mercedes", "Ferrari", "Opel", "Saab" };
            //cars.Remove("BMW");
            //cars.RemoveAt(2);

            //for (int index = 0; index < cars.Count; index++)
            //{
            //    Console.WriteLine(cars[index]);
            //}

            //var Humans1 = new List<Human>
            //{
            //    new Human(){Name = "Kalle", Age = 20 },
            //    new Human(){Name = "Malle", Age = 25 },
            //    new Human(){Name = "Mari", Age = 30 },
            //    new Human(){Name = "Elmar", Age = 35 },
            //    new Human(){Name = "Juku", Age = 40 }
            //};

            //var Human1 = new Human();
            //Human1.Name = "Priit";
            //Human1.Age = 25;
            //Humans1.Add(Human1);

            //var Human2 = new Human();
            //Console.WriteLine("Sisestage nimi");
            //Human2.Name = Console.ReadLine();
            //Console.WriteLine("Sisestage vanus");
            //Human2.Age = int.Parse(Console.ReadLine());
            //Humans1.Add(Human2);


            //foreach (var item in Humans1)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}


            ////ISESEISEV
            //var Humans = new List<Human>();
            //bool State = true;
            //while (State == true)
            //{
            //    var Human1 = new Human();
            //    Console.WriteLine("Sisestage nimi");
            //    Human1.Name = Console.ReadLine();
            //    Console.WriteLine("Sisestage vanus");
            //    Human1.Age = int.Parse(Console.ReadLine());
            //    Humans.Add(Human1);

            //    Console.WriteLine("Kas soovite veel sisestada? (y/n)");
            //    string vastus = Console.ReadLine().ToLower();
            //    if (vastus == "n") State = false;
            //}

            //foreach (var item in Humans)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}

            ////DICTIONARY
            //var openWith = new Dictionary<string, string>();
            //openWith.Add("txt", "notepad.exe");
            //openWith.Add("bmp", "paint.exe");
            //openWith.Add("jpg", "paint.exe");
            //openWith.Add("rtf", "wordpad.exe");

            //openWith["rtf"] = "winword.exe";
            //openWith["doc"] = "winword.exe";

            //try
            //{
            //    openWith.Add("txt", "word.exe");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("An element with key \"txt\" already exists.");
            //}

            //Console.WriteLine("For key = rtf, value = {0}", openWith["rtf"]);
            //Console.WriteLine("For key = doc, value = {0}", openWith["doc"]);
            //try
            //{
            //    Console.WriteLine("For key = tif, value = {0}", openWith["tif"]);
            //}
            //catch (KeyNotFoundException)
            //{
            //    Console.WriteLine("Key = \"tif\" is not found");
            //}

            //string value = "";
            //if (openWith.TryGetValue("tif", out value))
            //{
            //    Console.WriteLine("For key = \"tif\", value = {0}", value);
            //}
            //else
            //{
            //    Console.WriteLine("Key = \"tif\" is not found");
            //}

            //if (!openWith.ContainsKey("ht"))
            //{
            //    openWith.Add("ht", "hyperterm.exe");
            //    Console.WriteLine("Valuje added for key ht: {0}", openWith["ht"]);
            //}
        }
    }
}
