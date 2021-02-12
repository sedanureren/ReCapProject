using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba eklendi");
            }
            else
            {
                Console.WriteLine("Günlük fiyat kısmı 0'dan büyük olmalıdır.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine( "Araba silindi");

        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)

        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0) 
            {
                _carDal.Update(car);
                Console.WriteLine("Araba güncellendi.");
            }
            else
            {
                Console.WriteLine("Günlük fiyat 0'dan büyük olmalıdır.");
            }
        }
    }
}
