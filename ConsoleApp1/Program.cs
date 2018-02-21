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
            #region List
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

            #endregion
            #region Dictionary
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

            ////KONTROLLIME VÕTME "ht" OLEMASOLU NING TEME, KUI EI OLE
            //if (!openWith.ContainsKey("ht"))
            //{
            //    openWith.Add("ht", "hyperterm.exe");
            //    Console.WriteLine("Valuje added for key ht: {0}", openWith["ht"]);
            //}

            ////KÜSIME VÄÄRTUSEID KASUTADES foreach
            //var openWith = new Dictionary<string, string>();
            //openWith.Add("txt", "notepad.exe");
            //openWith.Add("bmp", "paint.exe");
            //openWith.Add("jpg", "paint.exe");
            //openWith.Add("rtf", "wordpad.exe");

            //openWith["rtf"] = "winword.exe";
            //openWith["doc"] = "winword.exe";

            //foreach (KeyValuePair<string, string> item in openWith)
            //{
            //    Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            //}

            ////Küsime väärtused
            //Dictionary<string, string>.ValueCollection valueCollection = openWith.Values;

            //foreach (string item in valueCollection)
            //{
            //    Console.WriteLine("Value = {0}", item);
            //}

            ////Küsime võtmed
            //Dictionary<string, string>.KeyCollection keyCollection = openWith.Keys;

            //foreach (string item in keyCollection)
            //{
            //    Console.WriteLine("Key = {0}", item);
            //}

            ////Kustutame võtme/väärtuse
            //openWith.Remove("doc");
            //if (!openWith.ContainsKey("doc"))
            //{
            //    Console.WriteLine("Key \"doc\" is not found");
            //}
            #endregion
            #region Queue = First in first out
            ////LOOME queue(järjekord)
            //Queue<string> numbers = new Queue<string>();
            //numbers.Enqueue("one");
            //numbers.Enqueue("two");
            //numbers.Enqueue("three");
            //numbers.Enqueue("four");
            //numbers.Enqueue("five");

            ////KÜSIMUSE ELEMENDID JÄRJEKORRAST
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            ////KUSTUTAME ELEMENDID JÄRJEKORRAST
            //Console.WriteLine("Dequeueing \"{0}\"", numbers.Dequeue());

            ////PIILUME (EI VÕTA VÄLJA) JÄRGMIST ELEMENTI
            //Console.WriteLine("Peek at next item to dequeue {0}", numbers.Peek());

            ////VÕTAME VÄLJA JÄRGMISE
            //Console.WriteLine("Dequeueing \"{0}\"", numbers.Dequeue());

            ////TEEME KOOPIA JÄRJEKORRAST
            //Queue<string> queueCopy = new Queue<string>(numbers.ToArray());
            //Console.WriteLine("\nContents of the first Copy");
            //foreach (string number in queueCopy)
            //{
            //    Console.WriteLine(number);
            //}

            ////QUEUE -> ARRAY

            //string[] array = new string[numbers.Count * 2];
            //numbers.CopyTo(array, numbers.Count);

            ////ARRAY -> QUEUE

            //Queue<string> queueCopy2 = new Queue<string>(array);
            //Console.WriteLine("\nContents of the second Copy, with duplicates and nulls:");
            //foreach (string number in queueCopy2)
            //{
            //    Console.WriteLine(number);
            //}

            ////KONTROLLIME ELEMENDI OLEMASOLU JÄRJEKORRAS
            //Console.WriteLine("\nqueueCopy contains \"four\" = {0}", queueCopy.Contains("four"));

            ////JÄRJEKORRAS TÜHJENDAMINE
            //queueCopy.Clear();
            //Console.WriteLine("\nqueueCopy count is {0}", queueCopy.Count);
            #endregion
            #region Stack = Last in first out
            //Console.WriteLine("Queue:");
            //Stack<string> numbers = new Stack<string>();
            //numbers.Push("one");
            //numbers.Push("two");
            //numbers.Push("three");
            //numbers.Push("four");
            //numbers.Push("five");

            //foreach (string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nPopping \"{0}\"", numbers.Pop());
            //Console.WriteLine("Peek at next item to destack: \"{0}\"", numbers.Peek());
            //Console.WriteLine("Popping \"{0}\"", numbers.Pop());
            #endregion
            #region LINQ
            ////ANDMEKOGUM
            //int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            ////LOOME PÄRINGU
            //var evenNumQuery = (from num in numbers
            //                    where (num % 2) == 0
            //                    select num).ToList();

            //var humans1 = new List<Human>
            //{
            //    new Human(){Name = "Kalle", Age = 30 },
            //    new Human(){Name = "Malle", Age = 25 },
            //    new Human(){Name = "Mari", Age = 40 },
            //    new Human(){Name = "Elmar", Age = 15 },
            //    new Human(){Name = "Juku", Age = 20 }
            //};

            ////SUUREMAD KUI 20 LÄHEVAD LISTI NING JARJESTAME TULEMUSED
            //var query = (from element in humans1
            //             orderby element.Age ascending
            //             where element.Age > 20
            //             select element).ToList();

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}

            //int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //var a = numbers.Contains(7);

            //var b = false;
            //foreach (var item in numbers)
            //{
            //    if (item == 6)
            //        b = true;
            //}
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            ////KERGEMAD FUNKTSIOONID
            //int[] numbers = new int[6] { 1, 2, 3, 4, 5, 6 };

            //var a = numbers.ElementAtOrDefault(15);
            //var b = numbers.FirstOrDefault();
            //var c = numbers.Take(3).ToList();
            //var d = numbers.Average();
            //var e = numbers.Max();
            //var f = numbers.Min();

            //Console.WriteLine("ElementArOrDefault " + a);
            //Console.WriteLine("FirstOrDefault " + b);
            //Console.WriteLine("Take 3");
            //foreach (var item in c)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Average " + d);
            //Console.WriteLine("Max " + e);
            //Console.WriteLine("Min " + f);


            ////OTSIME MINGI ELEMENDI JÄRGI
            //var g = humans1.Where(x => x.Name == "Kalle").FirstOrDefault();
            //var h = humans1.Where(x => x.Age == 40).ToList();
            //var i = humans1.Where(x => x.Name.Contains("a"));
            //var j = humans1.Where(x => x.Name.StartsWith("M"));
            //foreach (var item in h)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}
            //Console.WriteLine(g);

            //foreach (var item in i)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}

            //foreach (var item in j)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}

            //ISESEISEV
            var Auto1 = new List<Auto>
            {
                new Auto(){KW = 145, Tootja = "Ford", Mudel = "Galaxy", Värv = "Punane" },
                new Auto(){KW = 132, Tootja = "Ford", Mudel = "Edge", Värv = "Must" },
                new Auto(){KW = 83, Tootja = "Ford", Mudel = "Focus", Värv = "Hall" },
                new Auto(){KW = 100, Tootja = "Audi", Mudel = "A1", Värv = "Valge" },
                new Auto(){KW = 353, Tootja = "Nissan", Mudel = "GT-R", Värv = "Must" },
                new Auto(){KW = 104, Tootja = "Kia", Mudel = "Carens", Värv = "Roheline" },
                new Auto(){KW = 63, Tootja = "Kia", Mudel = "Rio", Värv = "Valge" },
                new Auto(){KW = 130, Tootja = "Kia", Mudel = "Optima", Värv = "Pruun" },
                new Auto(){KW = 81, Tootja = "Kia", Mudel = "Soul", Värv = "Punane" },
                new Auto(){KW = 136, Tootja = "Jeep", Mudel = "Cherokee", Värv = "Must" }
            };

            Console.WriteLine("Kilovattide järjestuses");
            var query1 = (from element in Auto1
                         orderby element.KW ascending
                         select element).ToList();
            foreach (var item in query1)
            {
                Console.WriteLine(item.Tootja + " " + item.Mudel + " " + item.KW + "KW");
            }

            Console.WriteLine("\nTootja nimes \"o\" täht");
            var query2 = Auto1.Where(x => x.Tootja.Contains("o"));
            foreach (var item in query2)
            {
                Console.WriteLine(item.Tootja + " " + item.Mudel + " " + item.KW + "KW");
            }

            Console.WriteLine("\nTootja nimes \"e\" täht");
            var query3 = Auto1.Where(x => x.Tootja.Contains("e"));
            foreach (var item in query3)
            {
                Console.WriteLine(item.Tootja + " " + item.Mudel + " " + item.KW + "KW");
            }

            Console.WriteLine("\nAuto mudel koosneb rohkem, kui 4 tähest");
            var query4 = (from element in Auto1
                         where element.Mudel.Length > 4
                         select element).ToList();
            foreach (var item in query4)
            {
                Console.WriteLine(item.Tootja + " " + item.Mudel + " " + item.KW + "KW");
            }

            var query5 = Auto1.OrderBy(x => x.KW).Last();
            Console.WriteLine("\nKõige võimsam auto: " + query5.Tootja + " " + query5.Mudel + " " + query5.KW + "KW");

            var query6 = Auto1.OrderBy(x => x.KW).First();
            Console.WriteLine("Kõige nõrgem auto: " + query6.Tootja + " " + query6.Mudel + " " + query6.KW + "KW");
            #endregion
        }

    }
}
