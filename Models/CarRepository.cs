using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace PolovniAutomobiliMVC.Models
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _db;

        public CarRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }

        public IEnumerable<Car> AllCars => _db.Cars.Include(c => c.Category);//if we want to load Category wich is
        //Sub property for our class Cars we need to type this Include(...) Because Entety fills only first prpertyes
        //And thinks that Category is only a foreign key. Thats called lazy loading
        public IEnumerable<Car> SpecialOfferCars => _db.Cars.Include(c => c.Category).Where(c => c.IsSpecialOffer);

        public Car GetCarById(int id)
        {
            return _db.Cars.Find(id);//Works becaus id is Primary key
            //return _db.Cars.FirstOrDefault(c => c.Id == id); Second option
        }
    }
}
