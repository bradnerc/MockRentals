using System.Linq;
using Vidly.Models;
using Vidly.Dtos;
using System.Web.Http;
using System;

namespace Vidly.Controllers.Api
{
    public class MovieReturnsController : ApiController
    {
        private ApplicationDbContext _context;
        // GET: Returns

        public MovieReturnsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult MovieReturns(NewRentalDto moviereturn)
        {
            var customer = _context.Customers.Single(
                c => c.Id == moviereturn.CustomerId);

            var movies = _context.Movies.Where(
                m => moviereturn.MovieIds.Contains(m.Id)).ToList();
                
            foreach (var movie in movies)
            {
                movie.NumberAvailable++;

                var rental = _context.Rentals.Single(m => m.Customer.Id == customer.Id &&
                m.Movie.Id == movie.Id);
                _context.Rentals.Remove(rental);
            }
            

            _context.SaveChanges();
            return Ok();
        }
    }
}