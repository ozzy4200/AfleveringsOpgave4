using AfleveringsOpgave4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AfleveringsOpgave4;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AfleveringsOpgave4.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController
    {
        //[Route("api/[controller]")]
       
       
            public static readonly List<Book> books = new List<Book>()
        {
            new Book("Osman", 500, "1234567891012", "NyBog"),
            new Book("Franco", 300,"1234567878907","Bog"),
        };

            // GET: api/Item
            [HttpGet]

            public IEnumerable<Book> Get()
            {
                return books;
            }

            // GET: api/Item/5
            //[HttpGet("{id}", Name = "Get")]
            [HttpGet]
            [Route("{isbn13}")]

            public Book Get(string isbn13)
            {
                return books.Find(i => i.Isbn13 == isbn13);
            }

            // POST: api/Item
            [HttpPost]
            public void Post([FromBody] Book value)
            {
                books.Add(value);
            }

            // PUT: api/Item/5
            //[HttpPut("{id}")]
            [HttpPut]
            [Route("{isbn13}")]
            public void Put(string isbn13, [FromBody] Book value)
            {
                Book book = Get(isbn13);
                if (book != null)
                {
                    book.Forfatter = value.Forfatter;
                    book.Sidetal = value.Sidetal;
                    book.Isbn13 = value.Isbn13;
                    book.Titel = value.Titel;
                }
            }

            // DELETE: api/ApiWithActions/5
            //[HttpDelete("{id}")]
            [HttpDelete]
            [Route("{isbn13}")]
            public void Delete(string isbn13)
            {
                Book book = Get(isbn13);
                books.Remove(book);
            }
            
        }
}


