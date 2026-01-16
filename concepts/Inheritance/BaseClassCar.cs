using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.concepts.Inheritance
{
    internal class BaseClassFourWheeler
    {
        public string EngineType { get; private set; }
        public string FuelType { get; private set; }
        public int EngineCapacity { get; private set; }
        public int Mileage {get; private set; }

        public BaseClassFourWheeler(string EngineType, string FuelType, int Mileage, int EngineCap)
        {
            this.EngineType = EngineType;
            this.FuelType = FuelType;
            this.EngineCapacity = EngineCap;
            this.Mileage = Mileage;
        }


    }
}
