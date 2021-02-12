using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length>=2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka eklendi.");
            }
            else
            {
                Console.WriteLine("Marka adı en az 2 karakter olmalıdır");
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka silindi");
        }

        public List<Brand> GetAll()
        {
             return _brandDal.GetAll();

        }

        public Brand GetBrandById(int id)
        {
            return _brandDal.Get(c => c.BrandId == id);
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length>=2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Marka Güncellendi.");
            }
            else
            {
                Console.WriteLine("Marka adı en az 2 karakter olmalıdır.");
            }
        }

        
    }
}
