using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.concepts.Inheritance
{
    internal class DerivedClassCar : BaseClassFourWheeler
    {
        public string CarType { get; set; }
        public string CarCompany { get; set; }
        public DerivedClassCar(string EngineType, string FuelType, int Mileage, int EngineCap, string carType, string carCompany) : base(EngineType, FuelType, Mileage, EngineCap)
        {
            CarType = carType;
            CarCompany = carCompany;
        }
        public void GetCarDetails()
        {
            Console.WriteLine($"Your Car is {CarCompany}, with {EngineCapacity}CC, {EngineType}, {FuelType} Engine. Its a {CarType} which give {Mileage} kmpl mileage");
        }
    }
}
