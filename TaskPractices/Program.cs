#region C# practice
// Olkeler olan list , console-dan sheher adi daxil olacaq listde olub olmamagin yoxlamaq

//using TaskPractices;



//string country = Console.ReadLine();

//static void CheckCountry(string country)
//{

//    var countries = Datas.Countries();
//    if (countries.Contains(country))
//    {
//        Console.WriteLine("Yes");
//    }
//    else
//    {
//        Console.WriteLine("No");
//    }
//}

//CheckCountry(country);

//Person classi olacaq , Id, FullName, Email, Birthday propertileri olmalidir.
//Service mentiqi olacaq. interface ve classi. 
//1) servisde butun personlari geri qaytaran method yazirsiz.


//using TaskPractices.Controllers;

//PersonController personController = new PersonController();
//personController.GetAll();
//personController.GetById();

//personController.Sorting();
#endregion


using TaskPractices;

//List<Book> books = new List<Book>() { new Book { Id = 1, Name = "Xosrov" }, new Book { Id = 2, Name = "Shirin" } };

Book book = new();
book.Id = 1;
book.Name = "Test1";

Library library = new();

library[0] = book;
Console.WriteLine(library[0].Name);








