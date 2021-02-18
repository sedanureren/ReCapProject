using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
        public class InMemoryCarDal : ICarDal
 {
        List<Car> _cars;
        public int brandId;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
               new Car{BrandId=1,CarId=1,ColorId=13,DailyPrice=150,ModelYear=2010,Description="Manuel" },
               new Car{BrandId=1,CarId=2,ColorId=14,DailyPrice=200,ModelYear=2016,Description="Otomatik" },
               new Car{BrandId=2,CarId=3,ColorId=15,DailyPrice=400,ModelYear=2020,Description="Otomatik" },
               new Car{BrandId=4,CarId=4,ColorId=16,DailyPrice=900,ModelYear=2018,Description="Otomatik" },
               new Car{BrandId=5,CarId=5,ColorId=17,DailyPrice=100,ModelYear=2012,Description="Manuel" },


            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {

            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
            
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByCar(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

       public void Update(Car car)
        {

            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
