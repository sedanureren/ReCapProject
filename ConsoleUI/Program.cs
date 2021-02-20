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
            //ManagerTest();
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetAll();

            foreach (var rental in result.Data)
            {
                Console.WriteLine(rental.CarId + " /" + rental.RentDate + "/" + rental.ReturnDate);
            }

        }

        private static void ManagerTest()
        {
            Console.WriteLine("Renkler");
            ColorManager colorManager1 = new ColorManager(new EfColorDal());
            foreach (var car in colorManager1.GetAll().Data)
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
            foreach (var car in colorManager2.GetAll().Data)
            {
                Console.WriteLine(car.ColorName);
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
            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "/" + car.CarName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }
    }
 }

