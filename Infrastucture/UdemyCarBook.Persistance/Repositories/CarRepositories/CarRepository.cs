﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Interfaces.CarRepositories;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistance.Context;


namespace UdemyCarBook.Persistence.Respositories.CarRepositories
{
    public class CarRepository :ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Car> GetCarsListWithBrands()
        {
            var values = _context.Cars.Include(x=>x.Brand).ToList();
            return values;
        }
    }
}
