using System;
using Domain.Models;
using Service.Interfaces;
using Service.Services;

namespace Main.Controllers
{
	public class LibraryController
	{
		private readonly ILibrary _libraryService;

		public LibraryController()
		{
			_libraryService = new LibraryService();
        }

		public void Show()
		{
			List<Author> result = _libraryService.FilterByAge(GetAuthors());

			foreach (Author author in result)
			{
				Console.WriteLine(author);
			}
        }

		private List<Author> GetAuthors()
		{
			Author author1 = new Author(1, "Ali", "Talibov", 21);
            Author author2 = new Author(2, "Cavid", "Bashirov", 29);
            Author author3 = new Author(3, "Oscar", "Baker", 45);
            Author author4 = new Author(4, "Kai", "Hunter", 40);
            Author author5 = new Author(5, "Rachel", "Doyle", 50);

			return new List<Author> { author1, author2, author3, author4, author5};
        }
	}
}