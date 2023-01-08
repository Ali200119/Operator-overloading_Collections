using System.Collections;
using Main.Models;

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

Hashtable datas = new Hashtable();

datas.Add(1, "Ali");
datas.Add(3, "Elcan");
datas.Add(2, "Cavid");

foreach (DictionaryEntry item in datas)
{
    if ((int)item.Key == 1)
    {
        Console.WriteLine(item.Value);
    }
}

#endregion