using Fuel.DAL.EF6.Contracts;
using Fuel.DAL.EF6.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.DAL.EF6.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FuelContext _context;

        public UnitOfWork(FuelContext context)
        {
            _context = context;
        }

        private ICarRepository _carRepository;
        private IRefuelingRepository _refuelingRepository;

        public ICarRepository CarRepository { get { return _carRepository ?? (_carRepository = new CarRepository(_context)); } }
        public IRefuelingRepository RefuelingRepository { get { return _refuelingRepository ?? (_refuelingRepository = new RefuelingRepository(_context)); } }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            Console.WriteLine("Wykonano :)");
        }
    }
}
