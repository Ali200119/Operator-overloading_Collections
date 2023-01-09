using System.Collections;
using Main.Models;

#region Non-Generic

#region Operator overloading

//Employee employee1 = new Employee
//{
//    Id = 1,
//    Name = "Ali",
//    Age = 30
//};

//Employee employee2 = new Employee
//{
//    Id = 2,
//    Name = "Cavid",
//    Age = 29
//};

//var result = employee1 > employee2;

//Console.WriteLine(result);

#endregion

#region Hashtable

//Hashtable datas = new Hashtable();

//datas.Add(1, "Ali");
//datas.Add(3, "Elcan");
//datas.Add(2, "Cavid");

//foreach (DictionaryEntry item in datas)
//{
//    if ((int)item.Key == 1)
//    {
//        Console.WriteLine(item.Value);
//    }
//}

#endregion

#region Sorted list

//SortedList datas = new SortedList();

//datas.Add(1, "Ali");
//datas.Add(3, "Elcan");
//datas.Add(2, "Cavid");

//foreach (DictionaryEntry item in datas)
//{
//    Console.WriteLine($"{item.Key}-{item.Value}");
//}

#endregion

#region Array list

//ArrayList datas = new ArrayList();

//datas.Add("Hello");
//datas.Add(1);
//datas.Add(true);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

#endregion

#endregion

#region Generic

#region List

//List<int> datas = new List<int>();

//datas.Add(7);
//datas.Add(30);
//datas.Add(19);

//datas.Sort();
//datas.Reverse();

//datas.Sort();

//Console.WriteLine(datas[0]);

//datas.Remove(30);

//datas.RemoveAt(2);

//datas.Clear();

//datas.RemoveAll(m=>m>20);

//bool res = datas.Contains(19);

//Console.WriteLine(res);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

//List<string> names = new List<string>() { "Cavid", "Cavid", "Aqshin", "Mirze", "Elcan" };

//Console.WriteLine(names.Count());

//foreach (var item in names)
//{
//    if (item == "Cavid")
//    {
//        Console.WriteLine(item);
//    }
//}

//for (int i = 0; i < names.Count(); i++)
//{
//    Console.WriteLine(names[i]);
//}

//string? result = names.Find(n => n == "Cavid");
//Console.WriteLine(result);

//int result = names.FindAll(n => n == "Cavid").Count();

//Console.WriteLine(result);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

//Console.WriteLine(numbers.Sum(n => n));

//Console.WriteLine(numbers.FindAll(n => n%2 == 0).Sum(n => n));

#endregion

#endregion