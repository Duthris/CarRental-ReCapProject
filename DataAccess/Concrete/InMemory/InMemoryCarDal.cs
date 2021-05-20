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
    public class InMemoryCarDal : ICarDal, IBrandDal, IColorDal
    {
        List<Car> _cars;
        List<Brand> _brands;
        List<Color> _colors;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2018, Description = "Hyundai TUCSON", DailyPrice = 200 },
                new Car{Id = 2, BrandId = 2, ColorId = 3, ModelYear = 2016, Description = "Skoda SUPERB", DailyPrice = 250 },
                new Car{Id = 3, BrandId = 2, ColorId = 4, ModelYear = 2010, Description = "Skoda Octavia", DailyPrice = 150 },
                new Car{Id = 4, BrandId = 3, ColorId = 2, ModelYear = 2011, Description = "Honda CIVIC", DailyPrice = 125 },
                new Car{Id = 5, BrandId = 4, ColorId = 1, ModelYear = 2020, Description = "Volkswagen Passat", DailyPrice = 350 },

            };

            _brands = new List<Brand>
            {
                new Brand{BrandId = 1, BrandName = "Hyundai"},
                new Brand{BrandId = 2, BrandName = "Skoda"},
                new Brand{BrandId = 3, BrandName = "Honda"},
                new Brand{BrandId = 4, BrandName = "Volkswagen"},
            };

            _colors = new List<Color>
            {
                new Color { ColorId = 1, ColorName = "Siyah" },
                new Color { ColorId = 2, ColorName = "Gri" },
                new Color { ColorId = 3, ColorName = "Beyaz"},
                new Color {ColorId = 4, ColorName = "Mavi"},
            };
        }

        public void Add(Car car)
        {
            car.Id = _cars.Count + 1;
            _cars.Add(car);
        }

        public void Add(Brand brand)
        {
            brand.BrandId = _brands.Count + 1;
            _brands.Add(brand);
        }

        public void Add(Color color)
        {
            color.ColorId = _colors.Count + 1;
            _colors.Add(color);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(b => b.BrandId == b.BrandId);
            _brands.Remove(brandToDelete);
        }

        public void Delete(Color color)
        {
            Color colorToDelete = _colors.SingleOrDefault(cl => cl.ColorId == cl.ColorId);
            _colors.Remove(colorToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAllBrands()
        {
            return _brands;
        }

        public List<Car> GetAllCars()
        {
            return _cars;
        }

        public List<Color> GetAllColors()
        {
            return _colors;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            brandToUpdate.BrandName = brand.BrandName;
        }

        public void Update(Color color)
        {
            Color colorToUpdate = _colors.SingleOrDefault(cl => cl.ColorId == color.ColorId);
            colorToUpdate.ColorName = color.ColorName;
        }

    }
}
