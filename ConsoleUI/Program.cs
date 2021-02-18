using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            ManagerTest();

        }

        private static void ManagerTest()
        {
            Console.WriteLine("Renkler");
            ColorManager colorManager1 = new ColorManager(new EfColorDal());
            foreach (var car in colorManager1.GetAll())
            {
                Console.WriteLine(car.ColorName);
            }

            Console.WriteLine("---------------------------------"


                                                                   );

            Console.WriteLine("Yeni Renk Ekleme");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Kırmızı" });
            Console.WriteLine("---------------------------------"


                                                                  );


            Console.WriteLine("Yeni renk ekleme sonucu");
            ColorManager colorManager2 = new ColorManager(new EfColorDal());
            foreach (var car in colorManager2.GetAll())
            {
                Console.WriteLine(car.ColorName);
            }
            Console.WriteLine("---------------------------------"


                                                                  );

            Console.WriteLine("Markalar");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var car in brandManager.GetAll())
            {
                Console.WriteLine(car.BrandName);
            }
            Console.WriteLine("---------------------------------"


                                                                  );


            Console.WriteLine("Markaları Güncelle");
            BrandManager brandManager1 = new BrandManager(new EfBrandDal());

            Console.WriteLine("---------------------------------"


                                                                  );
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetail())
            {
                Console.WriteLine(car.CarName+"/"+car.BrandName);
            }
        }
    }
 }

