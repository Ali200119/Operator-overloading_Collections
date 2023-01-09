using System;
using Domain.Models;
using Service.Interfaces;

namespace Service.Services
{
    public class LibraryService : ILibrary
    {
        public List<Author> FilterByAge(List<Author> authors)
        {
            return authors.FindAll(a => a.Age > 40);

            //List<Author> newList = new List<Author>();

            //foreach (Author author in authors)
            //{
            //    if (author.Age > 40)
            //    {
            //        newList.Add(author);
            //    }
            //}

            //return newList;
        }
    }
}