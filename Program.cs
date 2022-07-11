using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> nums = new List<int>();
            //nums.Add(1);
            //nums.Add(0);
            //nums.Add(1);
            //nums.Add(101);


            //List<string> words = new List<string>();
            //words.Add("Ilkin");
            //words.Add("101");

            //foreach (var item in words)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach(var item in nums) 
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < nums.Count; i++) 
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //if (nums.Count == 4) 
            //{
            //    Console.WriteLine("List count is {0}",nums.Count);

            //}

            //List<Person> people = new List<Person>();

            //Person person1 = new Person();
            //person1.Name = "Ilkin";
            //person1.ID = 1;
            //person1.Email = "Ilkin@gmail.com";


            //Person person2 = new Person
            //{
            //    ID = 1,
            //    Name = "Kenan",
            //    Email = "Kenan@gmail.com",
            //};

            //people.Add(person1);
            //people.Add(person2);



            //people.Add(new Person { ID = 1, Name = "Ilkin", Email = "Ilkin@gmail.com" });
            //people.Add(new Person { ID = 2, Name = "Orxan", Email = "Orxan@gmail.com" });
            //people.Add(new Person { ID = 3, Name = "Orxan", Email = "Orxan1@gmail.com" });
            //people.Add(new Person { ID = 3, Name = "Cavidan", Email = "Cavidan@gmail.com" });
            //people.Add(new Person { ID = 4, Name = "Nermin", Email = "Nermin@gmail.com" });

            //GetStudents(people);
            //GetNumbers(nums);

            //var result = GetPersobByNumbers(people, "Ilkin");
            //Console.WriteLine(result.Name + "-" + result.ID + "-" + result.Email);

            //var result = GetPeopleByName(people, "Orxan");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name + "-" + item.ID + "-" + item.Email);

            //}



            //Hashtable datas = new Hashtable();

            //datas.Add(1, "Togrul");
            //datas.Add(2, "Fidan");

            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value );
            //}

            //SortedList datas = new SortedList();
            //datas.Add(2, "Togrul");
            //datas.Add(5, "Fidan");
            //datas.Add(1, "Esqin");
            //datas.Add(3, "Seid");

            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}

            //SortedList<int, string> datas = new SortedList<int, string>();

            //datas.Add(6, "Azer");
            //datas.Add(4, "Huseyin");

            //foreach (KeyValuePair<int,string> item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}

            //ArrayList datas = new ArrayList();
            //datas.Add("Hello");
            //datas.Add(1);
            //datas.Add(true);


            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            //HashSet<int> datas = new HashSet<int>();
            //datas.Add(1);
            //datas.Add(3);
            //datas.Add(1);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}


            //Stack<int> datas = new Stack<int>();
            //datas.Push(1);
            //datas.Push(10);
            //datas.Push(21);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue<int> datas = new Queue<int>();
            //datas.Enqueue(11);
            //datas.Enqueue(22);
            //datas.Enqueue(78);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            Dictionary<string, string> datas = new Dictionary<string, string>();
            datas.Add("Admin", "Orxan");
            datas.Add("Memeber", "Mirsamir");
            datas.Add("Superadmin", "Cavid");

            foreach (KeyValuePair<string,string> item in datas)
            {
                if (item.Key == "Superadmin")
                {
                    Console.WriteLine($"Name : {item.Value}, Role : {item.Key}");
                    break;
                }
            }




        }

        

        //public static Person GetPersobByNumbers(List<Person> people, string name)
        //{
        //    var person = people.Find(m => m.Name == name);
        //    return person;
        //}

        //public static List<Person> GetPeopleByName(List<Person> people, string name)
        //{
        //    var persons = people.FindAll(m => m.Name == name);
        //    return persons;
        //}


        //public static void GetStudents(List<Person> students)
        //{
        //    foreach (var stu in students)
        //    {
        //        Console.WriteLine("Students : Id - {0}, Name - {1}, Email - {2}", stu.ID, stu.Name, stu.Email);
        //    }
        //}


        //public static void GetNumbers(List<int>numbers )
        //{
        //    foreach (var item in numbers)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

       

    }
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

}
