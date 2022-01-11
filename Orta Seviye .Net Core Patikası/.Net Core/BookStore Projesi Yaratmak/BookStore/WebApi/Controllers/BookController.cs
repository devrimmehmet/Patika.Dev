using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;
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
            new Book{
                Id=3,
                Title="Dune",
                GenreId=2, // Science Fiction
                PageCount=540,
                PublishDate=new System.DateTime(2002,12,21)
            }
        };

        [HttpGet]
        public List<Book> GetBooks()
        {
            var bookList = BookList.OrderBy(x=> x.Id).ToList<Book>();
            return bookList;
        }
        
        [HttpGet("{id}")] // idyi roottan alıyoruz.
        public Book GetById(int id)
        {
            var book = BookList.Where(book=> book.Id==id).SingleOrDefault();
            return book;
        }
        
       // [HttpGet] // idyi fromquery alıyoruz.
       // public Book Get ( [FromQuery] string id)
       // {
       //     var book = BookList.Where(book => book.Id == Convert.ToInt32(id)).SingleOrDefault();
       //     return book;
       // }
    }
}