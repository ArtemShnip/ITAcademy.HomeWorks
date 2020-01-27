using System;
using System.Reflection;

namespace Hw_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info(string.Concat("START_PROGRAMM:NAME " + Assembly.GetExecutingAssembly().GetName().Name + ", NAMESPACE " + Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace));

            MotoRepository repository = new MotoRepository();

            Logger.Log.Info("Get motorcycle by id");
            var moto = repository.GetMotorcycleById(2);
            Print(moto);

            Logger.Log.Info("Get all motorcycles");
            repository.GetMotorcycles();

            Logger.Log.Info("Create new motorcycle");
            repository.CreateMotorcycle(new Motorcycle()
            {
                Id = 5,
                Name = "Yamaha",
                Model = "YZF",
                Year = 2018,
                Odometer = 4_100,
            });

            Logger.Log.Info("Update motorcycle");
            repository.UpdateMotorcycle(new Motorcycle()
            {
                Id = 1,
                Name = "Minsk",
                Model = "112",
                Year = 1985,
                Odometer = 1300,
            });
            string eee = Console.ReadLine();

            Logger.Log.Info("Delete motorcycle");
            repository.DeleteMotorcycle(3);

            Logger.Log.Info("Ok");
            Console.ReadLine();
        }
        static void Print(Motorcycle motorcycle)
        {
            Console.WriteLine($" id = {motorcycle.Id}, name={motorcycle.Name}, model= {motorcycle.Model}, " +
                $"year= {motorcycle.Year}, odometer={motorcycle.Odometer}");
        }
        
    }
}
