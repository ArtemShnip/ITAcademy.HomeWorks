using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hw_12
{
    class MotoRepository
    {
        private List<Motorcycle> _list = new List<Motorcycle>();
        public MotoRepository()
        {
            _list = new List<Motorcycle>()
            {
                new Motorcycle()
                {
                    Id=1,
                    Name="Minsk",
                    Model="112",
                    Year=1985,
                    Odometer=100,
                },
                new Motorcycle()
                {
                    Id=2,
                    Name="Yamaha",
                    Model="Drag Star",
                    Year=2002,
                    Odometer=45000,
                },
                new Motorcycle()
                {
                    Id=3,
                    Name="Minsk",
                    Model="c4",
                    Year=2018,
                    Odometer=2000,
                },
                new Motorcycle()
                {
                    Id=4,
                    Name="Honda",
                    Model="CBF500",
                    Year=2008,
                    Odometer=9000,
                }
            };
        }

        public Motorcycle GetMotorcycleById(int id)
        {
            return _list.FirstOrDefault(x => x.Id == id);
        }

        public void GetMotorcycles()
        {
            foreach (var motorcycle in _list)
            {
                Console.WriteLine($"{motorcycle.Id}, {motorcycle.Name}, {motorcycle.Model}, {motorcycle.Year}," +
                    $" {motorcycle.Odometer}");
            }
        }

        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            _list.Add(motorcycle);
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            var motoUpdate = _list.FirstOrDefault(x => x.Id == motorcycle.Id);
            if (motoUpdate == null)
            {
                return;
            }
            motoUpdate.Model = motorcycle.Model;
            motoUpdate.Name = motorcycle.Name;
            motoUpdate.Year = motorcycle.Year;
            motoUpdate.Odometer = motorcycle.Odometer;
        }

        public void DeleteMotorcycle(int id)
        {
            var motorcycle = _list.FirstOrDefault(x => x.Id == id);
            if (motorcycle == null)
            {
                return;
            }
            else
            {
                _list.Remove(motorcycle);
            }
        }
    }
}
