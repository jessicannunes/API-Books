using Books_APIweb.Context;
using Books_APIweb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Books_APIweb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //injection AddDBContext class on controller class
        private readonly BookDbContext _dbContext;

        public BooksController(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // obter o produto
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            var books = _dbContext.Books;

            if(books is null)
            {
                return NotFound();
            }

            return books;
        }

        //obter o produto pelo id
        [HttpGet("{id:int}", Name="GetBook")]

        public ActionResult<Book> GetBook(int id)
        {
            var book = _dbContext.Books.FirstOrDefault(p=> p.Id == id);

            if(book == null)
            {
                return NotFound("Livro não encontrado");
            }
            return book;
        }

        // Atualizar o produto
        [HttpPost]
        public ActionResult PostBook(Book book)
        {
            if(book == null)
                return BadRequest();
            
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();

            return new CreatedAtRouteResult("GetBook", 
                new { id = book.Id }, book);
        }

        //inserir produto
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Book book)
        {
            if(id!= book.Id)
            {
                return BadRequest();
            }

            _dbContext.Entry(book).State = EntityState.Modified;
            _dbContext.SaveChanges();

            return Ok(book);
        }

        //Deletar produto
        [HttpDelete("{id:int}")]

        public ActionResult DeleteBook(int id)
        {
            var book = _dbContext.Books.FirstOrDefault(p=> p.Id==id);
           
            if(book is null)
            {
                return NotFound("Produto não localizado");
            }

            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();

            return Ok();
        }
       

    }
}
