using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class BookController : ControllerBase
    {
        private static List<Book> BookList =new List<Book>()
        {
            new Book{
                Id=1,
                Title="Lean Startup",
                GenreId=1, // Personel Growth
                PageCount=200,
                PublishDate=new System.DateTime(2001,06,12)
            },
            new Book{
                Id=2,
                Title="Herland",
                GenreId=2, // Science Fiction
                PageCount=250,
                PublishDate=new System.DateTime(2010,05,23)
            },
        }
    }
}