using Business.Concrete;
using DataAccess.Abstract;
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

            Car newCar1 = new Car
            {
                Id = 6,
                BrandId = 4,
                ModelYear = 2021,
                Description = "Sedan",
                ColorId = 6,
                DailyPrice = 400,
                CarName = "Volkswagen JETTA"
            };

            Car newCar2 = new Car
            {
                Id = 7,
                BrandId = 5,
                ModelYear = 2018,
                Description = "Hatchback",
                ColorId = 7,
                DailyPrice = 275,
                CarName = "Seat LEON"
            };

            Car newCar3 = new Car
            {
                Id = 8,
                BrandId = 1,
                ModelYear = 2017,
                Description = "Hatchback",
                ColorId = 5,
                DailyPrice = 175,
                CarName = "Hyundai i20"
            };


            //GetAllTest();
            //GetCarDetails();
            //GetCarsByDailyPrice();
            //GetCarsByBrandId();
            //RentalTest();


            Console.ReadLine();

        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CarManager carManager = new CarManager(new EfCarDal());

            Rental newRental1 = new Rental
            {
                Id = 1,
                CarId = 2,
                CustomerId = 1,
                RentDate = new DateTime(2021, 3, 2),
                ReturnDate = new DateTime(2021, 3, 8)
            };

            Customer newCustomer1 = new Customer
            {
                Id = 1,
                UserId = 1,
            };

            Rental newRental2 = new Rental
            {
                Id = 2,
                CarId = 3,
                CustomerId = 2,
                RentDate = new DateTime(2021, 3, 4),
                ReturnDate = new DateTime(2021, 3, 11)
            };

            Customer newCustomer2 = new Customer
            {
                Id = 2,
                UserId = 2,
            };

            customerManager.Add(newCustomer2);
            rentalManager.Add(newRental2);

            var result = rentalManager.GetRentalDetails();

            if (result.Success == true)
            {
                Console.WriteLine("\n#################### Güncel Kiralama Listesi ####################\n");

                foreach (var rental in result.Data)
                {
                    Console.WriteLine("Araç numarası: " + rental.CarId + "\n" +
                                      "Araç Marka ve Modeli: " + rental.CarName + "\n" +
                                      "Araç Model Yılı: " + rental.ModelYear + "\n" +
                                      "Aracın günlük ücreti: " + rental.DailyPrice + "\n" +
                                      "Kiralayan kişinin adı: " + rental.FirstName + "\n" +
                                      "Kiralayan kişinin soyadı: " + rental.LastName + "\n" +
                                      "Kiralanma tarihi: " + rental.RentDate + "\n" +
                                      "Geri teslim tarihi: " + rental.ReturnDate + "\n" +
                                      "--------------------------------------------------------\n");
                }
            }

            else
            {
                Console.WriteLine(result.Message + "\n");
            }
        }

        private static void GetCarsByDailyPrice()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetByDailyPrice(100, 200);

            if (result.Success == true)
            {
                Console.WriteLine("\n#################### Belirtilen fiyat aralığındaki araçlar ####################\n");

                foreach (var car in result.Data)
                {
                    Console.WriteLine("Aracın Model Yılı: " + car.ModelYear + "\n" +
                                      "Araç Marka ve Modeli: " + car.CarName + "\n" +
                                      "Aracın Günlük Ücreti: " + car.DailyPrice + " TL\n" +
                                      "--------------------------------------------------------\n"
                                      );
                }
            }

            else
            {
                Console.WriteLine(result.Message + "\n");
            }
        }


        private static CarManager GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarsByBrandId(2);

            if (result.Success == true)
            {
                Console.WriteLine("\n########### Marka Numarasına Kayıtlı Araçlar ###########\n");

                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "\n");
                }
            }

            else
            {
                Console.WriteLine(result.Message + "\n");
            }

            return carManager;
        }


        private static void GetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                Console.WriteLine("\n#################### Sistemde Kayıtlı Araçlar ####################\n");

                foreach (var car in result.Data)
                {
                    Console.WriteLine("Aracın Markası: " + car.BrandName + "\n" +
                                      "Aracın Rengi: " + car.ColorName + "\n" +
                                      "Aracın Marka ve Modeli: " + car.CarName + "\n" +
                                      "Aracın Model Yılı: " + car.ModelYear + "\n" +
                                      "Aracın Günlük Ücreti: " + car.DailyPrice + " TL\n" +
                                      "--------------------------------------------------------\n"
                                      );
                }
            }

            else
            {
                Console.WriteLine(result.Message + "\n");
            }
        }

        private static void GetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();

            if (result.Success == true)
            {
                Console.WriteLine("\n############ SİSTEMDE KAYITLI ARAÇLAR ############\n");

                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0}: {1}", car.Id, car.CarName);
                }
            }

            else
            {
                Console.WriteLine(result.Message + "\n");
            }
        }
    }
}
