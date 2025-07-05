using System;
using System.Reflection;

namespace RefleksijaZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PRVI DEO: Refleksija nad klasom System.String ===\n");

            Type stringType = typeof(string);
            Console.WriteLine($"Naziv klase: {stringType.Name}");
            Console.WriteLine($"Prostor imena: {stringType.Namespace}");
            Console.WriteLine($"Sklop (Assembly): {stringType.Assembly.FullName}");
            Console.WriteLine($"Baza (nasleđuje): {stringType.BaseType}");
            Console.WriteLine($"Interfejsi koje implementira:");
            foreach (var inter in stringType.GetInterfaces())
            {
                Console.WriteLine($" - {inter.Name}");
            }

            Console.WriteLine($"Da li je apstraktna: {stringType.IsAbstract}");
            Console.WriteLine($"Da li je zapečaćena: {stringType.IsSealed}");
            Console.WriteLine($"Da li je generička: {stringType.IsGenericType}");

            Console.WriteLine("\n=== DRUGI DEO: Refleksija nad klasom Country ===\n");

            
            Type countryType = typeof(Country);

            
            object countryInstance = Activator.CreateInstance(countryType, "Italy", 60000000);

            
            MethodInfo method = countryType.GetMethod("GetCountryInfo");

            
            string result = (string)method.Invoke(countryInstance, null);

            Console.WriteLine(result);

            Console.WriteLine("\nPritisnite bilo koji taster za izlaz...");
            Console.ReadKey();
        }
    }

    
    class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public Country(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public string GetCountryInfo()
        {
            return $"Country {Name} has the population of {Population}.";
        }
    }
}
