using Books_APIweb.Context;
using Microsoft.AspNetCore.Mvc;

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


    }
}
