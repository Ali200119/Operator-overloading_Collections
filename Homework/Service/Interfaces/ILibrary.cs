using System;
using Domain.Models;

namespace Service.Interfaces
{
	public interface ILibrary
	{
		List<Author> FilterByAge(List<Author> authors);
	}
}